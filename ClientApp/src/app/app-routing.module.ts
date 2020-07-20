import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuard } from './_helpers/auth.guard';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './_auth/login/login.component';
import {ProfileComponent} from "@app/_auth/profile/profile.component";
import {UserListComponent} from "@app/_auth/user-management/user-list.component";
import {LogComponent} from "@app/components/log/log.component";

const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'profile',
    component: ProfileComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'userlist',
    component: UserListComponent,
    canActivate: [AuthGuard]
  },
  {
    path: 'loglist',
    component: LogComponent,
    canActivate: [AuthGuard]
  },
  { path: '**', redirectTo: '' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
