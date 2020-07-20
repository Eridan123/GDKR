import {Component, OnInit} from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from './_services/authentication.service';
import { User } from './_models/user';
import ruMessages from 'devextreme/localization/messages/ru.json';
import { locale, loadMessages } from 'devextreme/localization';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  currentUser: User;

  constructor(
      private router: Router,
      public authenticationService: AuthenticationService
  ) {
      this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
      loadMessages(ruMessages);
      locale('ru');
  }

  logout() {
      this.authenticationService.logout();
      this.router.navigate(['/login']);
  }
  ngOnInit(): void {
  }
}
