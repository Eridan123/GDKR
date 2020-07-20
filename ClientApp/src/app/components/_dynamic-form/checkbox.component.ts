import { Component, OnInit } from '@angular/core';
import { FieldConfig } from './IField';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-checkbox',
  template: `
  <div style="margin: 10px 0;" [formGroup]="group">
    <dx-check-box
      [validationStatus]="isValid"
      [formControlName]="field.name"
      [text]="field.label">
    </dx-check-box>
  </div>
  `,
  styles: []
})
export class CheckboxComponent implements OnInit {
  field: FieldConfig;
  group: FormGroup;
  constructor() {}
  ngOnInit() {}

  get isValid() {
    return this.group.controls[this.field.name].valid ? 'valid' : 'invalid';
  }
}
