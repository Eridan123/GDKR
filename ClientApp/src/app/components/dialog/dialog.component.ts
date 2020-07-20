import { Component, OnInit, Inject } from '@angular/core';
import { FieldConfig } from '../_dynamic-form/IField';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { HttpClient } from '@angular/common/http';

import notify from 'devextreme/ui/notify';
import {ApiResponse} from '@app/components/base';
import {AppConstantsService} from "@app/_services/constants.service";

@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.css']
})
export class DialogComponent implements OnInit {

  fields: FieldConfig[];
  form: FormGroup;
  title: string;
  canEdit = true;
  // !this.form.disabled
  disabled: any;

  constructor(private fb: FormBuilder,
              private http: HttpClient,
              private dialogRef: MatDialogRef<DialogComponent>,
              private constants: AppConstantsService,
              @Inject(MAT_DIALOG_DATA) public options: any) {
    this.fields = options.FieldConfigs;
    this.title = options.title;
  }

  ngOnInit(): void {
    this.form = this.createControl();
    if(this.options.canEdit != null && this.options.canEdit == false)
    {
      this.canEdit = false;
      this.form.setErrors(null);
      this.form.disable();
    }

  }

  submit() {

    if (this.form.valid) {
      this.disabled = true;
      const path = this.form.value.Id === 0 ? '/create' : this.form.value.Id !== undefined ? `/edit/${this.form.value.Id}`: '';
      this.http.post(`${this.constants.apiUrl}/${this.options.url}${path}`, this.form.value)
      .subscribe(
        e => {
          const apiResponse: ApiResponse = e as ApiResponse;
          const type = apiResponse.hasError ? 'error' : 'success';
          notify(apiResponse.message, type, 3000);
          this.dialogRef.close(true);
          },
        () => { this.dialogRef.close(false); }
      );
    } else {
      this.validateAllFormFields(this.form);
    }
  }

  close() {
    this.dialogRef.close(false);
  }

  createControl() {
    const group = this.fb.group({});
    const fa = this.fb.array([]);

    this.fields.forEach(field => {

      if (field.type === 'button') { return; }

      if (!field.nestedForm) {
        const control = this.fb.control(field.value, this.bindValidations(field.validations || []));
        group.addControl(field.name, control);
      } else {
        const fg = this.fb.group({});

        field.nestedForm.forEach(f => {
          const control = this.fb.control(f.value, this.bindValidations(f.validations || []));
          fg.addControl(f.name, control);
        });
        fa.push(fg);
        if(field.type == 'formArray')
        {
          group.addControl('productsArray', fa);
        }
        else
        {
          group.addControl('productList', fa);
        }
      }
    });

    return group;
  }

  bindValidations(validations: any) {
    if (validations.length > 0) {
      const validList = [];
      validations.forEach(valid => {
        validList.push(valid.validator);
      });
      return Validators.compose(validList);
    }
    return null;
  }

  validateAllFormFields(formGroup: FormGroup) {
    Object.keys(formGroup.controls).forEach(field => {
      const control = formGroup.get(field);
      control.markAsTouched({ onlySelf: true });
    });
  }
}
