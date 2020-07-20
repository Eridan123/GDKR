import { Component, OnInit } from '@angular/core';
import { FieldConfig } from './IField';
import { FormGroup } from '@angular/forms';
import {environment} from "@environments/environment";
import {AppConstantsService} from "@app/_services/constants.service";

@Component({
  selector: 'app-link',
  template: `
  <div>
    <table style="width:100%; margin: 10px 0;">
      <tr *ngFor="let attachment of field.value">
        <td class="td-border">
            <a href="{{url}}/attachment/download/{{attachment.id}}" target="_blank">{{attachment.name}}</a>
        </td>
      </tr>
    </table>
  </div>
  `,
  styles: [`
    a { text-decoration: none !important; color: gray; }
    .td-border { border-bottom: 1px solid #c0c0c0; padding: 8px 0; }
  `]
})
export class LinkComponent implements OnInit {

  constructor(private constants: AppConstantsService) {}
  ngOnInit() {}
  url = this.constants.apiUrl;
  field: FieldConfig;
  group: FormGroup;

}
