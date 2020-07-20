import { Component, OnInit } from '@angular/core';
import { FieldConfig } from './IField';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-hidden',
  template: `
  <div [formGroup]="group">
    <input hidden [formControlName]="field.name">
  </div>
  `,
  styles: []
})

export class HiddenComponent implements OnInit {
  field: FieldConfig;
  group: FormGroup;
  constructor() {}
  ngOnInit() {}
}
