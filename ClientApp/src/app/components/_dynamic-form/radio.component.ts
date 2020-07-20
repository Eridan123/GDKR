import { Component, OnInit } from '@angular/core';
import { FieldConfig } from './IField';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-radio',
  template: `
  <div [formGroup]="group">
    <label class="radio-label-padding">{{field.label}}:</label>
    <mat-radio-group [formControlName]="field.name">
      <mat-radio-button *ngFor="let item of field.options">{{item}}</mat-radio-button>
    </mat-radio-group>
  </div>
  `,
  styles: []
})
export class RadioComponent implements OnInit {
  field: FieldConfig;
  group: FormGroup;
  constructor() {}
  ngOnInit() {}
}
