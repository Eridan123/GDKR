import { Component, OnInit } from '@angular/core';
import { FieldConfig } from './IField';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-number-input',
  template: `
  <div [formGroup]="group" class="pad">
    <dx-number-box
      [validationStatus]="isValid"
      [formControlName]="field.name"
      [placeholder]="field.label"
      [showSpinButtons]="false"
      [showClearButton]="true">
    </dx-number-box>
  </div>
  `,
  styles: ['.pad { padding: 5px 0; }']
})
export class NumberInputComponent implements OnInit {
  field: FieldConfig;
  group: FormGroup;
  constructor() {}
  ngOnInit() {}

  get isValid() {
    return this.group.controls[this.field.name].valid ? 'valid' : 'invalid';
  }
}
