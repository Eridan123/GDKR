import { Component, OnInit } from '@angular/core';
import { FieldConfig } from './IField';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-input',
  template: `
  <div class="pad" [formGroup]="group">
    <dx-text-box
      [validationStatus]="isValid"
      [formControlName]="field.name"
      [placeholder]="field.label"
      [mode]="field.inputType"
      autocomplete="off">
    </dx-text-box>
  </div>
  `,
  styles: ['.pad { padding: 5px 0; }']
})
export class InputComponent implements OnInit {
  field: FieldConfig;
  group: FormGroup;
  constructor() {}
  ngOnInit() {}

  get isValid() {
    return this.group.controls[this.field.name].valid ? 'valid' : 'invalid';
  }
}
