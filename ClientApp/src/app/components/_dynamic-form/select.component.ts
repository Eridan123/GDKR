import { Component, OnInit } from '@angular/core';
import { FieldConfig } from './IField';
import { FormGroup } from '@angular/forms';
import { AuthenticationService } from '@app/_services/authentication.service';
import ODataStore from 'devextreme/data/odata/store';
import { environment } from '@environments/environment';
import DataSource from 'devextreme/data/data_source';
import {AppConstantsService} from "@app/_services/constants.service";

@Component({
  selector: 'app-select',
  template: `
  <div class="pad" [formGroup]="group">
    <dx-select-box
      [id]="selectId"
      value="Id"
      valueExpr="Id"
      searchMode="contains"
      searchTimeout="300"
      [validationStatus]="isValid"
      [displayExpr]="displayExpr"
      [placeholder]="field.label"
      [formControlName]="field.name"
      [dataSource]="dataSource"
      [searchExpr]="searchExpr"
      [minSearchLength]="msl"
      (onChange)="field.onChange"
      [visible]="field.visible"
      [searchEnabled]="searchEnabled">
    </dx-select-box>
  </div>
  `,
  styles: ['.pad { padding: 5px 0; }']
})
export class SelectComponent implements OnInit {

  constructor(public authenticationService: AuthenticationService, private constants: AppConstantsService) {
    this.selectId = 'select_' + Math.random().toString(36).substring(7);
  }

  field: FieldConfig;
  group: FormGroup;
  selectId: string;
  displayExpr: string;
  dataSource: any;
  searchExpr: any;
  msl: number;
  searchEnabled: boolean;
  currentUser = this.authenticationService.currentUserValue;

  ngOnInit() {
    const selectSource = this.field.dataSource;
    this.searchEnabled = selectSource.searchEnabled;
    this.msl = selectSource.msl;
    this.displayExpr = selectSource.displayExpr;
    this.searchExpr = selectSource.searchExpr || 'Name';
    this.field.visible = this.field.visible || true;

    this.dataSource = selectSource.dataSourceUrl
    ? new DataSource({
        store: new ODataStore({
            version: 4,
            url: `${this.constants.apiUrl}/odata/${selectSource.dataSourceUrl}`,
            beforeSend: (e) => {
                e.headers = {
                    Authorization: `Bearer ${this.currentUser.token}`,
                };
            }
        }),
        select: selectSource.select,
        filter: [[ 'MarkAsDeleted', '=', false ]].concat(selectSource.filter),
        expand: selectSource.expand
      })
    : this.field.options;
  }
  get isValid() {
    return this.group.controls[this.field.name].valid ? 'valid' : 'invalid';
  }
}
