import { Component, OnInit } from '@angular/core';
import { FieldConfig } from './IField';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-readonlyInput',
  template: `
    <div [formGroup]="group">
      <mat-form-field class="full-width">
        <mat-label>{{ field.label }}</mat-label>
        <input matInput disabled [formControlName]="field.name">
      </mat-form-field>
    </div>
  `,
  styles: ['.full-width { width: 100% }']
})
export class ReadonlyFieldComponent implements OnInit {
  field: FieldConfig;
  group: FormGroup;
  constructor() {}
  ngOnInit() {}
}
