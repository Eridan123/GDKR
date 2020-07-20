import { Component, OnInit } from '@angular/core';
import { FieldConfig } from './IField';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-checkbox-list',
  template: `
    <div class="pad" [formGroup]="group">
      <mat-selection-list dense [formControlName]="field.name">
        <mat-list-option *ngFor="let option of field.options" [value]="option.Id">
          {{ option.Description }}
        </mat-list-option>
      </mat-selection-list>
    </div>
  `,
  styles: [`
    .pad {
      padding: 5px 0;
      overflow:scroll; height:300px;
    }
    .mat-list-base .mat-list-item, .mat-list-base .mat-list-option {
      height: 26px;
    }
  `]
})
export class CheckboxListComponent implements OnInit {
  field: FieldConfig;
  group: FormGroup;
  constructor() {}
  ngOnInit() {}
}
