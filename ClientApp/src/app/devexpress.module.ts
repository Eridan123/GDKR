import {NgModule} from '@angular/core';

import {
  DxBoxModule,
  DxButtonModule,
  DxCheckBoxModule,
  DxDataGridModule,
  DxDateBoxModule,
  DxDropDownBoxModule, DxLoadPanelModule,
  DxNumberBoxModule,
  DxSelectBoxModule,
  DxTemplateModule,
  DxTextAreaModule,
  DxTextBoxModule,
  DxTreeListModule
} from 'devextreme-angular';

@NgModule({
    imports: [
        DxDataGridModule,
        DxSelectBoxModule,
        DxCheckBoxModule,
        DxTemplateModule,
        DxButtonModule,
        DxTreeListModule,
        DxBoxModule,
        DxTextBoxModule,
        DxDateBoxModule,
        DxDropDownBoxModule,
        DxTextAreaModule,
        DxNumberBoxModule,
        DxLoadPanelModule
    ],
    exports: [
        DxDataGridModule,
        DxSelectBoxModule,
        DxCheckBoxModule,
        DxTemplateModule,
        DxButtonModule,
        DxTreeListModule,
        DxBoxModule,
        DxTextBoxModule,
        DxDateBoxModule,
        DxDropDownBoxModule,
        DxTextAreaModule,
        DxNumberBoxModule,
        DxLoadPanelModule
    ]
  })
  export class DevexpressModule {}
