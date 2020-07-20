import {Directive, Input, ComponentFactoryResolver, ViewContainerRef, OnInit} from '@angular/core';
import { FieldConfig } from './IField';
import { FormGroup } from '@angular/forms';
import { InputComponent } from './input.component';
import { SelectComponent } from './select.component';
import { DateComponent } from './date.component';
import { CheckboxComponent } from './checkbox.component';
import { RadioComponent } from './radio.component';
import { HiddenComponent } from './hidden.component';
import { TextareaComponent } from './textarea.component';
import { FormArrayComponent } from './form-array.component';
import { NumberInputComponent } from './number-input.component';
import {CheckboxListComponent} from '@app/components/_dynamic-form/checkbox-list.component';
import {ReadonlyFieldComponent} from "@app/components/_dynamic-form/readonly-field.component";
import {LinkComponent} from "@app/components/_dynamic-form/link.component";
import {ProductListComponent} from "@app/components/_dynamic-form/product-list.component";

const componentMapper = {
  input: InputComponent,
  select: SelectComponent,
  date: DateComponent,
  radiobutton: RadioComponent,
  checkbox: CheckboxComponent,
  hidden: HiddenComponent,
  textarea: TextareaComponent,
  formArray: FormArrayComponent,
  numberInput: NumberInputComponent,
  checkboxList: CheckboxListComponent,
  readOnlyInput: ReadonlyFieldComponent,
  linkInput: LinkComponent,
  productList: ProductListComponent
};

@Directive({
  selector: '[dynamicField]'
})
export class DynamicFieldDirective implements OnInit {
  @Input() field: FieldConfig;
  @Input() group: FormGroup;
  componentRef: any;

  constructor(
    private resolver: ComponentFactoryResolver,
    private container: ViewContainerRef
  ) {}

  ngOnInit() {
    const factory = this.resolver.resolveComponentFactory(
      componentMapper[this.field.type]
    );
    this.componentRef = this.container.createComponent(factory);
    this.componentRef.instance.field = this.field;
    this.componentRef.instance.group = this.group;
  }
}
