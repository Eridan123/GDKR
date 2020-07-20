import {Component, ElementRef, OnDestroy, OnInit, Renderer2, ViewChild} from '@angular/core';
import {User, USER_COLUMNS, UserFields} from '@app/_models/user';
import {DataTableDirective} from 'angular-datatables';
import {Subject} from 'rxjs';
import {HttpClient} from '@angular/common/http';
import {DT} from '@app/components/dataTable';
import {AuthenticationService} from '@app/_services/authentication.service';
import {DialogService} from '@app/components/dialog/dialog.service';
import {AppConstantsService} from "@app/_services/constants.service";
import {SwalComponent} from "@sweetalert2/ngx-sweetalert2";

@Component({
  selector: 'app-user-list',
  templateUrl: './user-management.html',
  styleUrls: ['./user-management.css']
})
export class UserListComponent implements OnInit, OnDestroy {

  constructor(
    private http: HttpClient,
    private dialog: DialogService,
    public elementRef: ElementRef,
    private renderer: Renderer2,
    private authenticationService: AuthenticationService,
    private constants: AppConstantsService) {
    this.authenticationService.currentUser.subscribe(x => this.currentUser = x);

    renderer.listen(elementRef.nativeElement, 'click', (event) => {
      if (event.target.hasAttribute('view-id')) {
          this.edit(event.target.getAttribute('view-id'));
      }
    });
  }

  currentUser: User;

  // Settings
  title = 'Пользователи';
  subtitle = '';
  componentUrl = 'auth/user';
  componentColumns: any = USER_COLUMNS;


  @ViewChild(DataTableDirective)
  datatableElement: DataTableDirective;
  dtOptions: DataTables.Settings = {};
  dtTrigger: Subject<boolean> = new Subject();

  loadFields(item: any) {
    return UserFields(item);
  }
  openDialog(fc: any): void {

    const data = { FieldConfigs: this.loadFields(fc), url: this.componentUrl };
    this.dialog.open(data);

    this.dialog.done().subscribe(confirmed => {
      if (confirmed) {
        this.datatableElement.dtInstance.then((dtInstance: DataTables.Api) => dtInstance.draw());
      }
    });
  }
  edit(id: number): void {
    this.http.get(`${this.constants.apiUrl}/auth/user/${id}`)
        .subscribe(resp => {
          this.openDialog(resp)
        });
  }
  create() { this.openDialog(new User()); }
  ngOnInit() {
    this.dtOptions = new DT(this.http, true, 'auth/users', this.componentColumns, this.constants).loadConfig();
  }
  ngOnDestroy(): void { this.dtTrigger.unsubscribe(); }
}
