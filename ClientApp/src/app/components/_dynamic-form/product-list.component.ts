import {Component, OnInit} from '@angular/core';
import {FieldConfig} from './IField';
import {FormArray, FormBuilder, FormGroup} from '@angular/forms';
import ODataStore from 'devextreme/data/odata/store';
import {AuthenticationService} from '@app/_services/authentication.service';
import DataSource from 'devextreme/data/data_source';
import {AppConstantsService} from "@app/_services/constants.service";

@Component({
  selector: 'app-form-product-list',
  template: `
  <div [formGroup]="group">
        <div formArrayName="productList">
            <div *ngFor="let item of productList.controls; let i=index">
                <dx-box direction="row" width="100%" [formGroupName]="i">
                    <dxi-item [ratio]="6" style="margin:5px 0;">
                        <dx-select-box
                            formControlName="Product"
                            placeholder="Наименование государственной/муниципальной платной услуги"
                            [dataSource]="products"
                            valueExpr="Id"
                            required="true"
                            displayExpr="Name"
                            searchMode="contains"
                            searchTimeout="300"
                            minSearchLength="0"
                            [validationStatus]="validationStatus(i)"
                            searchEnabled="false">
                        </dx-select-box>
                    </dxi-item>
                    <dxi-item [ratio]="1" style="margin:5px;">
                        <dx-button
                            stylingMode="contained"
                            text="Удалить"
                            type="Normal"
                            width="120"
                            [disabled]="disabled"
                            (onClick)="deleteItem(i)">
                        </dx-button>
                    </dxi-item>
                </dx-box>
            </div>
            <dx-button
                style="margin:10px 0;"
                stylingMode="contained"
                text="Добавить"
                type="Normal"
                [disabled]="!isValid"
                [width]="120"
                (onClick)="addItem()">
            </dx-button>
        </div>
  </div>
  `,
  styles: ['mat-form-field { width: 100%; }']
})
export class ProductListComponent implements OnInit {

  constructor(private fb: FormBuilder,
              private constants: AppConstantsService,
              public authenticationService: AuthenticationService) {  }


  field: FieldConfig;
  group: FormGroup;
  productList: FormArray;
  disabled = true;
  currentUser = this.authenticationService.currentUserValue;
  products: any;

  get itemArray() {
    return this.group.get('productList') as FormArray;
  }
  get isValid() {
    return this.itemArray.valid;
  }
  validationStatus(i) {
    return this.itemArray.controls[i].get('Product').valid ? 'valid' : 'invalid';
  }
  ngOnInit() {
    this.products = new DataSource({
      store: new ODataStore({
        version: 4,
        url: `${this.constants.apiUrl}/odata/${this.field.dataSource.dataSourceUrl}`,
        beforeSend: (e) => {
          e.headers = {
            Authorization: `Bearer ${this.currentUser.token}`,
          };
        },
        key: 'Id'
      }),
      select: [ 'Id', 'Name' ],
      filter: [['MarkAsDeleted', '=', false]] //.concat(this.field.dataSource.filter)
    });

    this.productList = this.group.get('productList') as FormArray;
  }
  addItem() {
    const product = this.fb.group({
      Product: []
    });
    this.itemArray.push(product);
    this.disabled = false;
  }
  deleteItem(i) {
    if (this.itemArray.length > 1) {
      this.itemArray.removeAt(i);
    }

    if (this.itemArray.length === 1) {
      this.disabled = true;
    }
  }
}
