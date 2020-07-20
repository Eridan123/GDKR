import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from '@app/_services/authentication.service';
import { first } from 'rxjs/operators';
import { MatSnackBar } from '@angular/material/snack-bar';
import notify from "devextreme/ui/notify";
import {ApiResponse} from "@app/components/base";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm: FormGroup;
  loading = false;
  submitted = false;
  returnUrl: string;
  error = '';

  constructor(
      private formBuilder: FormBuilder,
      private route: ActivatedRoute,
      private router: Router,
      private authenticationService: AuthenticationService,
      private snackBar: MatSnackBar) {
      if (this.authenticationService.currentUserValue) {
          this.router.navigate(['/']);
      }
    }

  ngOnInit() {
      this.loginForm = this.formBuilder.group({
          userName: ['', Validators.required],
          password: ['', Validators.required]
      });

      this.returnUrl = this.route.snapshot.queryParams.returnUrl || '/';
  }

  get f() { return this.loginForm.controls; }

  onSubmit() {

    this.submitted = true;
    if (this.loginForm.invalid) {
      if (this.f.userName.errors.required) {
        this.showErrorMessage('Логин не может быть пустым', '');
      }
      if (this.f.password.errors.required) {
        this.showErrorMessage('Пароль не может быть пустым', '');
      }
      return;
    }

    this.loading = true;
    this.authenticationService.login(this.f.userName.value, this.f.password.value)
        .pipe(first())
        .subscribe(
            e => {

              this.router.navigate([this.returnUrl]).then(() => {
                this.loading = false;
              });
            },
            error => {
              this.error = error;
              this.loading = false;
              this.showErrorMessage(this.error, '');
            });
  }

  showErrorMessage(message, action) {
    this.snackBar.open(message, action, {
      duration: 2000,
    });
  }

}
