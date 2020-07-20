import { Component, OnInit } from '@angular/core';
import { FieldConfig } from './IField';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-textarea',
  template: `
  <div class="pad" [formGroup]="group">
    <dx-text-area
      autoResizeEnabled="true"
      [validationStatus]="isValid"
      [placeholder]="field.label"
      [formControlName]="field.name">
    </dx-text-area>
  </div>
  `,
  styles: ['.pad { padding: 5px 0; }']
})
export class TextareaComponent implements OnInit {
  field: FieldConfig;
  group: FormGroup;
  constructor() {}
  ngOnInit() {}
  get isValid() {
    return this.group.controls[this.field.name].valid ? 'valid' : 'invalid';
  }
}
