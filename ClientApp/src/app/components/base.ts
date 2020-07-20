import {FieldConfig} from "@app/components/_dynamic-form/IField";

export interface ApiResponse {
  hasError: boolean;
  message: string;
}

export class DataTablesResponse {
  data: any[];
  draw: number;
  recordsFiltered: number;
  recordsTotal: number;
}

export class Base {
    id = 0;
}

export function BaseFields(entity: any): FieldConfig[] {
  return [{ type: 'hidden', name: 'Id', value: entity.id  }];
}
