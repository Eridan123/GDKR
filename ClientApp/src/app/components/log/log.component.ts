import {Component, OnInit, ViewChild} from '@angular/core';
import { LOG_COLUMNS } from '@app/_models/log';
import {DataTableDirective} from "angular-datatables";
import {Subject} from "rxjs";
import { DT } from '../dataTable';
import {HttpClient} from "@angular/common/http";
import { AppConstantsService } from '@app/_services/constants.service';

@Component({
  selector: 'app-log',
  templateUrl: './log.component.html',
  styleUrls: ['./log.component.css']
})
export class LogComponent implements OnInit {

  constructor(private http: HttpClient, private constants: AppConstantsService){}

  // Settings
  title = 'Последние действия';
  subtitle = '';
  componentUrl = 'loglist';
  componentColumns: any = LOG_COLUMNS;

  @ViewChild(DataTableDirective)
  datatableElement: DataTableDirective;
  dtOptions: DataTables.Settings = {};
  dtTrigger: Subject<boolean> = new Subject();

  ngOnInit() {
    this.dtOptions = new DT(this.http, true, this.componentUrl, this.componentColumns, this.constants).loadConfig();
  }

}
