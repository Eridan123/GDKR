import {Component, OnInit} from '@angular/core';
import {FieldConfig} from './IField';
import {FormArray, FormBuilder, FormGroup} from '@angular/forms';
import {environment} from '@environments/environment';
import ODataStore from 'devextreme/data/odata/store';
import {AuthenticationService} from '@app/_services/authentication.service';
import DataSource from 'devextreme/data/data_source';
import {AppConstantsService} from "@app/_services/constants.service";

@Component({
  selector: 'app-form-array',
  template: `
  <div [formGroup]="group">
        <div formArrayName="productsArray">
            <div *ngFor="let item of productsArray.controls; let i=index">
                <dx-box direction="row" width="100%" [formGroupName]="i">
                    <dxi-item [ratio]="5" style="margin:5px 0;">
                        <dx-select-box
                            formControlName="Product"
                            placeholder="Товар/Услуга"
                            [dataSource]="products"
                            valueExpr="Id"
                            displayExpr="Name"
                            searchMode="contains"
                            searchTimeout="300"
                            minSearchLength="0"
                            required="true"
                            [validationStatus]="validationProductStatus(i)"
                            searchEnabled="false">
                        </dx-select-box>
                    </dxi-item>
                    <dxi-item [ratio]="1" style="margin:5px;">
                        <dx-number-box
                            value="1.0"
                            formControlName="Price"
                            placeholder="Цена"
                            required="true"
                            [validationStatus]="validationPriceStatus(i)"
                            [showSpinButtons]="false"
                            [showClearButton]="true">
                        </dx-number-box>
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
                [width]="120"
                [disabled]="!isValid"
                (onClick)="addItem()">
            </dx-button>
        </div>
  </div>
  `,
  styles: ['mat-form-field { width: 100%; }']
})
export class FormArrayComponent implements OnInit {

    constructor(private fb: FormBuilder,
                private constants: AppConstantsService,
                public authenticationService: AuthenticationService) { }

    currentUser = this.authenticationService.currentUserValue;

    field: FieldConfig;
    group: FormGroup;
    productsArray: FormArray;
    disabled = true;
    products = new DataSource({
        store: new ODataStore({
            version: 4,
            url: `${this.constants.apiUrl}/odata/product`,
            beforeSend: (e) => {
                e.headers = {
                    Authorization: `Bearer ${this.currentUser.token}`,
                };
            },
            key: 'Id'
        }),
        select: [ 'Id', 'Name' ],
        filter: ['MarkAsDeleted', '=', false]
    });

    get itemArray() {
        return this.group.get('productsArray') as FormArray;
    }
    get isValid() {
        return this.itemArray.valid;
    }
    validationProductStatus(i) {
        return this.itemArray.controls[i].get('Product').valid ? 'valid' : 'invalid';
    }
    validationPriceStatus(i) {
      return this.itemArray.controls[i].get('Price').valid ? 'valid' : 'invalid';
    }
    ngOnInit() {
        this.productsArray = this.group.get('productsArray') as FormArray;
    }
    addItem() {
        const product = this.fb.group({
            Product: [],
            Price: []
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
