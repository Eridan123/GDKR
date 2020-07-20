import { HttpClient } from '@angular/common/http';
import {AppConstantsService} from "@app/_services/constants.service";
import {DataTablesResponse} from "@app/components/base";

export class DT {
    constructor(
      private http: HttpClient,
      private ordering: boolean,
      private url: string,
      private columns: any,
      private constants: AppConstantsService,
      private rowCallBack?: any) {}


    loadConfig(xtra?: any): any {

        return {
          pagingType: 'full_numbers',
          serverSide: true,
          processing: true,
          scrollCollapse: true,
          autoWidth: false,
          ordering: true,

          responsive: {
            details: {
              type: 'column'
            }
          },
          columnDefs: [
            {
              className: 'control',
              orderable: false,
              targets:   0
            }
          ],
          order: [[ 0, 'asc' ]],
          colReorder: {
            fixedColumnsLeft: 2
          },
          language : {
            processing: 'Подождите...',
            search: 'Поиск:',
            lengthMenu: 'Показать _MENU_ записей',
            info: 'Записи с _START_ до _END_ из _TOTAL_ записей',
            infoEmpty: 'Записи с 0 до 0 из 0 записей',
            infoFiltered: '(отфильтровано из _MAX_ записей)',
            infoPostFix: '',
            loadingRecords: 'Загрузка записей...',
            zeroRecords: 'Записи отсутствуют.',
            emptyTable: 'В таблице отсутствуют данные',
            paginate: {
              first: 'Первая',
              previous: 'Предыдущая',
              next: 'Следующая',
              last: 'Последняя'
            },
          },
          dom: 'l<"clear">tip',
          lengthMenu: [
            [ 10, 25, 50, 100 ],
            [ '10', '25', '50', '100' ],
            {
              text: 'Показать _MENU_ записей'
            }
          ],

          ajax: (dataTablesParameters: any, callback) => {
            this.http
              .post<DataTablesResponse>(`${this.constants.apiUrl}/${this.url}`, dataTablesParameters, { } )
              .subscribe(resp => {
                callback({
                  recordsTotal: resp.recordsTotal,
                  recordsFiltered: resp.recordsFiltered,
                  data: resp.data
                });
              });
          },
          columns: this.columns,
          rowCallback: this.rowCallBack
        };
      }
}
