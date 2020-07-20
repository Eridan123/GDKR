import { Component, OnInit } from '@angular/core';
import { FieldConfig } from './IField';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-date',
  template: `
    <div class="pad" [formGroup]="group">
      <dx-date-box
        [validationStatus]="isValid"
        [formControlName]="field.name"
        [placeholder]="field.label"
        [useMaskBehavior]="true"
        displayFormat="dd.MM.yyyy"
        type="date"
        pickerType="calendar"
        dateSerializationFormat="yyyy-MM-ddTHH:mm:ss"
        showAnalogClock="false"
        showClearButton="true">
      </dx-date-box>
    </div>
  `,
  styles: ['.pad { padding: 5px 0; }']
})
export class DateComponent implements OnInit {
  field: FieldConfig;
  group: FormGroup;
  constructor() {}
  ngOnInit() {}

  get isValid() {
    return this.group.controls[this.field.name].valid ? 'valid' : 'invalid';
  }
}
