import {Base, BaseFields} from "@app/components/base";
import {Validators} from "@angular/forms";

const USER_COLUMNS = [
  { data : 'id', name : 'Id', width: '10px', render(data) { return ''; } },
  {
    data: 'id',
    name: 'Id',
    width: '20px',
    searchable : false,
    title: '',
    render(data: any) {
      return '<button class="mat-icon-button mat-primary material-icons" view-id="' + data + '">label</button>';
    }
  },
  { data : 'userName', name : 'UserName', title : 'Пользователь' },
  { data : 'firstName', name : 'FirstName', title : 'Имя' },
  { data : 'lastName', name : 'ДastName', title : 'Фамилия' }
];
export { USER_COLUMNS };

export class User extends Base {

  userName: string;
  firstName: string;
  lastName?: string;
  isAdmin?: boolean = false;
  token?: string;
}

export function UserFields(user: User) {
  const fields =
    [
      {
        type: !user.isAdmin ? 'input' : 'hidden',
        label: 'Логин',
        name: 'UserName',
        inputType: 'text',
        value: user.userName,
        validations: [
          {
            name: 'required',
            validator: Validators.required,
            message: 'Заполните поле'
          },
          {
            name: 'pattern',
            validator: Validators.pattern('^[A-Za-z][A-Za-z0-9]*'),
            message: 'не правильные данные'
          }]
      },
      {
        type: 'input',
        label: 'Имя',
        name: 'FirstName',
        value: user.firstName,
        validations: [
          {
            name: 'required',
            validator: Validators.required,
            message: 'Заполните поле'
          }]
      },
      {
        type: 'input',
        label: 'Фамилия',
        name: 'LastName',
        inputType: 'text',
        value: user.lastName,
        validations: [
          {
            name: 'required',
            validator: Validators.required,
            message: 'Заполните поле'
          }]
      },
    ];

  return BaseFields(user).concat(fields);
}
