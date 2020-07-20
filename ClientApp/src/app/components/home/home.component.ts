import {Component, enableProdMode, OnInit} from '@angular/core';
import 'devextreme/data/odata/store';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {FormBuilder, FormControl, FormGroup, Validators} from '@angular/forms';
import {MatDialog} from '@angular/material/dialog';
import {Router} from '@angular/router';
import {AuthenticationService} from '@app/_services/authentication.service';
import {AppConstantsService} from "@app/_services/constants.service";
import {Observable} from "rxjs";
import {resp1, resp2, resp3, resp4, resp5, resp6, SubjectByResponseModel} from "@app/components/home/models";
import {first} from "rxjs/operators";
import notify from "devextreme/ui/notify";

if (!/localhost/.test(document.location.host)) {
  enableProdMode();
}
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  preserveWhitespaces: true
})
export class HomeComponent implements OnInit {

  constructor(private http: HttpClient,
              private formBuilder: FormBuilder,
              public dialog: MatDialog,
              public authenticationService: AuthenticationService,
              private router: Router,
              private constants: AppConstantsService) {}

  ngOnInit(): void { }

  expanded: any = false;
  loadingVisible: boolean = false;

  dxDataSource: any;
  dxColumns = SubjectByResponseModel;

  addressResult: resp1;
  zagsResult: resp2;
  stringResult: any;
  passportResult: resp3;
  foreignResult: resp4;
  organizationByNameResult: resp5;
  organizationByPinResult: resp6;

  zags = new FormGroup({
    name: new FormControl('', Validators.required),
    surname: new FormControl('', Validators.required),
    patronymic: new FormControl('', Validators.required),
    birthDate: new FormControl('', Validators.required)
  });
  passport = new FormGroup({
    pin: new FormControl('', Validators.required),
    series: new FormControl('', Validators.required),
    number: new FormControl('', Validators.required),
  });
  foreign = new FormGroup({
    doc: new FormControl('', Validators.required),
    code: new FormControl('', Validators.required),
  });

  addressPin = new FormControl('');
  zagsPin = new FormControl('');
  organizationPin = new FormControl('');
  organizationName = new FormControl('');

  addressSearchButton = {
    icon: 'search',
    type: 'default',
    onClick: () => { this.search('addressPin'); }
  };
  zagsSearchButton = {
    icon: 'search',
    type: 'default',
    onClick: () => { this.search('zagsPin'); }
  };
  organizationPinSearchButton = {
    icon: 'search',
    type: 'default',
    onClick: () => { this.search('organizationPin'); }
  };
  organizationNameSearchButton = {
    icon: 'search',
    type: 'default',
    onClick: () => { this.search('organizationName'); }
  };

  onSubmit(form: string) {
    this.search(form)
  }
  search(e) {
    if(e === 'addressPin') {
      this.getData('getAddressByPin', JSON.stringify(this.addressPin.value))
        .pipe(first())
        .subscribe(resp => {
            this.addressResult = resp;
            this.loadingVisible = false;
            this.expanded = true;
          },
          error => {
            this.loadingVisible = false;
            notify('Нет данных', 'success', 3000);
          });
    }
    if(e === 'zagsPin') {
      this.getData('getZagsByPin', JSON.stringify(this.zagsPin.value))
        .pipe(first())
        .subscribe(resp => {
            this.zagsResult = resp;
            this.loadingVisible = false;
            this.expanded = true;
          },
          error => {
            this.loadingVisible = false;
            notify('Нет данных', 'success', 3000);
          });
    }
    if(e === 'zags') {
      this.getData('zagsPinsByNSPDate', this.zags.value)
        .pipe(first())
        .subscribe(resp => {
            this.stringResult = resp;
            this.loadingVisible = false;
            this.expanded = true;
          },
          error => {
            this.loadingVisible = false;
            notify('Нет данных', 'success', 3000);
          });
    }
    if(e === 'passport') {
      this.getData('passportDataByPSN', this.passport.value)
        .pipe(first())
        .subscribe(resp => {
            this.passportResult = resp;
            this.loadingVisible = false;
            this.expanded = true;
          },
          error => {
            this.loadingVisible = false;
            notify('Нет данных', 'success', 3000);
          });
    }
    if(e === 'foreign') {
      this.getData('foreignByDocRequest', this.foreign.value)
        .pipe(first())
        .subscribe(resp => {
            this.foreignResult = resp;
            this.loadingVisible = false;
            this.expanded = true;
          },
          error => {
            this.loadingVisible = false;
            notify('Нет данных', 'success', 3000);
          });
    }
    if(e === 'organizationPin') {
      this.getData('getsubjectbytin', JSON.stringify(this.organizationPin.value))
        .pipe(first())
        .subscribe(resp => {
            this.organizationByPinResult = resp;
            this.loadingVisible = false;
            this.expanded = true;
          },
          error => {
            this.loadingVisible = false;
            notify('Нет данных', 'success', 3000);
          });
    }
    if(e === 'organizationName') {
      this.getData('getsubjectbyname', JSON.stringify(this.organizationName.value))
        .pipe(first())
        .subscribe(
          resp => {
            this.dxDataSource = resp;
            this.loadingVisible = false;
            this.expanded = true;
          },
          error => {
            this.loadingVisible = false;
            notify('Нет данных', 'success', 3000);
          });
    }
  }
  onChange(){
    this.expanded = false;
  }
  getData(path: string, data: any): Observable<any> {
    this.loadingVisible = true;

    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json-patch+json',
        'Access-Control-Allow-Origin': '*'
      })
    };

    Object.keys(data).forEach(key => data[key] === '' && delete data[key]);
    return this.http.post<any>(`${this.constants.apiUrl}/api/${path}`,  data, httpOptions);
  }
}

