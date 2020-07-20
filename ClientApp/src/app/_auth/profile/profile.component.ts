import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthenticationService } from '@app/_services/authentication.service';
import { User, UserFields } from '@app/_models/user';
import { Router } from '@angular/router';
import {DialogService} from '@app/components/dialog/dialog.service';
import {FieldConfig} from "@app/components/_dynamic-form/IField";
import {Validators} from "@angular/forms";

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent {

  currentUser: User;
  title = 'Пользователь';
  subtitle = '';
  componentUrl = 'auth/changePassword';
  componentItem: any = new User();

  constructor(private http: HttpClient,
              private router: Router,
              private dialog: DialogService,
              private authenticationService: AuthenticationService) {

    this.authenticationService.currentUser.subscribe(u => this.currentUser = u);
  }

  loadFields() {
    const fields: FieldConfig[] =
      [
        {
          type: 'input',
          label: 'Старый пароль',
          inputType: 'password',
          name: 'OldPassword',
          value: '',
          validations: [
            {
              name: 'required',
              validator: Validators.required,
              message: 'Заполните поле'
            }
          ]
        },
        {
          type: 'input',
          label: 'Новый пароль',
          inputType: 'password',
          name: 'NewPassword',
          value: '',
          validations: [
            {
              name: 'required',
              validator: Validators.required,
              message: 'Заполните поле'
            }
          ]
        }
      ];
    return fields;
  }

  openDialog(): void {

    const data = { FieldConfigs: this.loadFields(), url: this.componentUrl };
    this.dialog.open(data);
    this.dialog.done().subscribe(confirmed => {
      if (confirmed) {
        console.log('');
      }
    });
  }
  changePassword() { this.openDialog(); }
}
