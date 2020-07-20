export interface req1 {
  name?: string;
  surname?: string;
  patronymic?: string;
  birthDate?: Date;
}
export interface req2 {
  pin?: string;
  series?: string;
  number?: string;
}
export interface req3 {
  doc?: string;
  code?: string;
}

//****************************************
export interface resp1 {
  error?: boolean;
  address?: string;
}
export interface resp2 {
  pin?: string;
  pinGenerationDate?: Date;
  surname?: string;
  name?: string;
  patronymic?: string;
  gender?: string;
  dateOfBirth?: Date;
  maritalStatus?: string;
  maritalStatusId?: string;
  nationality?: string;
  nationalityId?: string;
  citizenship?: string;
  citizenshipId?: string;
  pinBlocked?: string;
  deathDate?: Date;
}
export interface resp3 {
  pin?: string;
  surname?: string;
  name?: string;
  patronymic?: string;
  nationality?: string;
  dateOfBirth?: Date;
  passportSeries?: string;
  passportNumber?: string;
  voidStatus?: string;
  issuedDate?: Date;
  passportAuthority?: string;
  expiredDate?: Date;
  voidMotiv?: string;
  familyStatus?: string;
  gender?: string;
  addressRegion?: string;
  addressLocality?: string;
  addressStreet?: string;
  addressHouse?: string;
  addressBuilding?: string;
  addressApartment?: string;
}
export interface resp41 {
  surname?: string;
  name?: string;
  patronymic?: string;
  birthdate?: Date;
  gender?: number;
  citizenship?: string;
  docDateIssue?: Date;
  docDateExpiration?: Date;
  regDateFrom?: Date;
  regDateTo?: Date;
  regAddress?: string;
}
export interface resp4 {
  error?: boolean;
  message?: resp41;
}
export interface resp51 {
  fullName?: string;
  citizenship?: string;
  tin?: string;
}
export interface resp5 {
  fullNameGl?: string;
  shortNameGl?: string;
  fullNameOl?: string;
  shortNameOl?: string;
  foreignPart?: boolean;
  registrCode?: string;
  statSubCode?: number;
  tin?: string;
  region?: string;
  district?: string;
  city?: string;
  microdistrict?: string;
  street?: string;
  house?: string;
  room?: string;
  phones?: string;
  email1?: object;
  orderDate?: Date;
  ownership?: number;
  category?: number;
  chief?: string;
  description?: string;
  baseBusinessCode?: string;
  baseBusCode?: string;
  indFounders?: number;
  jurFounders?: number;
  totalFounders?: number;
  founder?: resp51[];
}
export interface resp6 {
  fullNameGl?: string;
  shortNameGl?: string;
  fullNameOl?: string;
  shortNameOl?: string;
  foreignPart?: boolean;
  registrCode?: string;
  statSubCode?: string;
  tin?: string;
  region?: string;
  district?: string;
  city?: string;
  village?: string;
  microdistrict?: string;
  street?: string;
  house?: string;
  room?: string;
  phones?: string;
  email1?: string;
  email2?: string;
  orderDate?: string;
  firstOrderDate?: string;
  ownership?: number;
  chiefTin?: string;
  baseBus?: string;
  baseBusCode?: string;
  indFounders?: number;
  jurFounders?: number;
  totalFounders?: number;
}

export const  SubjectByResponseModel = [
  { dataField: 'fullNameGl', caption: 'Полное наименование на гос. языке', width: '25%' },
  { dataField: 'shortNameGl', caption: 'Краткое наименование на гос. языке', width: '15%' },
  { dataField: 'fullNameOl', caption: 'Полное наименование на офиц. языке', width: '25%'},
  { dataField: 'shortNameOl', caption: 'Краткое наименование на офиц. языке', width: '15%'},
  { dataField: 'registrCode', caption: 'Код рег.', width: '10%'},
  { dataField: 'tin', caption: 'ИНН', width: '10%'},
];


