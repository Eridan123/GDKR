import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { User } from '@app/_models/user';
import {AppConstantsService} from "@app/_services/constants.service";
import {ApiResponse} from "@app/components/base";
import notify from "devextreme/ui/notify";

@Injectable({ providedIn: 'root' })
export class AuthenticationService {

    private currentUserSubject: BehaviorSubject<User>;
    public currentUser: Observable<User>;
    public user: User;

    constructor(private http: HttpClient, private constants: AppConstantsService) {
        this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('currentUser')));
        this.currentUser = this.currentUserSubject.asObservable();
        this.currentUser.subscribe(u => { this.user = u; });
    }

    public get currentUserValue(): User {
        return this.currentUserSubject.value;
    }

    login(userName: string, password: string) {
        return this.http.post<any>(`${this.constants.apiUrl}/auth/authenticate`, { userName, password })
            .pipe(map(resp => {
              const apiResponse: ApiResponse = resp as ApiResponse;
              if(apiResponse.hasError)
              {
                notify(apiResponse.message, 'error', 3000);
              }

              if (resp && resp.token) {
                  localStorage.setItem('currentUser', JSON.stringify(resp));
                  this.currentUserSubject.next(resp);
              }
              return resp;
            }));
    }

    logout() {
        localStorage.removeItem('currentUser');
        this.currentUserSubject.next(null);
    }
}
