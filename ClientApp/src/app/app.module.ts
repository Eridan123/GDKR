import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { DataTablesModule } from 'angular-datatables';
import { JwtInterceptor } from './_helpers/jwt.interceptor';
import { ErrorInterceptor } from './_helpers/error.interceptor';
import { MaterialModule } from './material.module';
import { LoginComponent } from './_auth/login/login.component';
import { HomeComponent } from './components/home/home.component';
import { DevexpressModule } from './devexpress.module';
import { AngularSplitModule } from 'angular-split';
import { MAT_DIALOG_DEFAULT_OPTIONS } from '@angular/material/dialog';
import config from 'devextreme/core/config';
import {MatTableModule} from '@angular/material/table';
import {NgMultiSelectDropDownModule} from 'ng-multiselect-dropdown';
import {SweetAlert2Module} from '@sweetalert2/ngx-sweetalert2';
import {DevExtremeModule} from 'devextreme-angular';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {AppConstantsService} from "@app/_services/constants.service";
import { UserListComponent } from './_auth/user-management/user-list.component';
import {InputComponent} from "@app/components/_dynamic-form/input.component";
import {CheckboxComponent} from "@app/components/_dynamic-form/checkbox.component";
import {DialogComponent} from "@app/components/dialog/dialog.component";
import {RadioComponent} from "@app/components/_dynamic-form/radio.component";
import {TextareaComponent} from "@app/components/_dynamic-form/textarea.component";
import {CheckboxListComponent} from "@app/components/_dynamic-form/checkbox-list.component";
import {ProductListComponent} from "@app/components/_dynamic-form/product-list.component";
import {LinkComponent} from "@app/components/_dynamic-form/link.component";
import {ReadonlyFieldComponent} from "@app/components/_dynamic-form/readonly-field.component";
import {NumberInputComponent} from "@app/components/_dynamic-form/number-input.component";
import {FormArrayComponent} from "@app/components/_dynamic-form/form-array.component";
import {HiddenComponent} from "@app/components/_dynamic-form/hidden.component";
import {DateComponent} from "@app/components/_dynamic-form/date.component";
import {SelectComponent} from "@app/components/_dynamic-form/select.component";
import {DialogService} from "@app/components/dialog/dialog.service";
import {ProfileComponent} from "@app/_auth/profile/profile.component";
import {DynamicFieldDirective} from "@app/components/_dynamic-form/dynamic-field.directive";
import { LogComponent } from './components/log/log.component';

config({
  editorStylingMode: 'filled',
});

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    UserListComponent,
    ProfileComponent,
    DynamicFieldDirective,

    InputComponent,
    DateComponent,
    RadioComponent,
    SelectComponent,
    DynamicFieldDirective,
    CheckboxComponent,
    DialogComponent,
    HiddenComponent,
    TextareaComponent,
    FormArrayComponent,
    NumberInputComponent,
    CheckboxListComponent,
    ReadonlyFieldComponent,
    LinkComponent,
    ProductListComponent,
    LogComponent,
  ],
  imports: [
    BrowserModule,
    MaterialModule,
    DevexpressModule,

    AngularSplitModule.forRoot(),
    SweetAlert2Module.forRoot(),

    BrowserAnimationsModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    DataTablesModule,
    FormsModule,
    MatTableModule,
    NgMultiSelectDropDownModule,
    DevExtremeModule,
    MatProgressSpinnerModule,



  ],
  entryComponents: [
    DialogComponent,

    InputComponent,
    SelectComponent,
    DateComponent,
    RadioComponent,
    CheckboxComponent,
    HiddenComponent,
    TextareaComponent,
    FormArrayComponent,
    NumberInputComponent,
    CheckboxListComponent,
    ReadonlyFieldComponent,
    LinkComponent,
    ProductListComponent
  ],
  providers: [
    DialogService,
    AppConstantsService,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
    { provide: MAT_DIALOG_DEFAULT_OPTIONS,
      useValue: { autoFocus: false, width: '70%', hasBackdrop: true, disableClose: true }
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
