export interface Validator {
    name: string;
    validator: any;
    message: string;
}

export interface KeyValue {
  Id: any;
  Name: string;
  Description?: string;
}

export interface SelectSource {
  dataSourceUrl?: string;
  select?: string[];
  filter?: any[];
  expand?: string[];
  searchEnabled?: boolean;
  msl?: number;
  displayExpr?: string;
  searchExpr?: string[];
}

export interface FieldConfig {
  label?: string;
  name?: string;
  inputType?: string;
  options?: KeyValue[];
  dataSource?: SelectSource;
  collections?: any;
  type: string;
  value?: any;
  validations?: Validator[];
  isRequired?: boolean;
  isMultiple?: boolean;
  nestedForm?: FieldConfig[];
  onChange?: any;
  visible?: boolean;
}
