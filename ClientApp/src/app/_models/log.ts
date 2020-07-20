import {Base, BaseFields} from "@app/components/base";

export class Log {
  EntityName: string;
  DateTime: Date;
  ActionType: number;
  Id: number;
  EntityId: number;
  Username: string;
  Details: string;
}
const actions = [{ key: 0, value: 'Вход' }, { key: 1, value: 'Выход' }, { key: 2, value: 'Добавил'}, { key: 3, value: 'Изменил'}, { key: 4, value: 'Удалил'}, { key: 5, value: 'СМЭВ Түндүк'}];
const LOG_COLUMNS = [
  { data: 'id', name: 'Id', title: 'ИД', visible: false},
  { data: 'entityId', name: 'EntityId', title: 'Л', visible: false},
  { data: 'actionType', name: 'ActionType', title: 'Действие', width: '110px',
    render(data) {
      return actions[data].value;
    }
  },
  { data: 'entityName', name: 'EntityName', title: 'Описание',
    render(data) {
      return ENTITY_NAMES[data];
    }
  },
  { data: 'dateTime', name: 'DateTime', title: 'Дата', width: '200px', },
  { data: 'username', name: 'Username', title: 'Пользователь' },
  { data: 'details', name: 'Details', title: 'Детали' },
];
export { LOG_COLUMNS };

const ENTITY_NAMES = {
  null: 'Логин',
  Login: 'В систему',
  getAddressByPin: 'ГРС - Адрес по (ПИН)',
  getZagsByPin: 'ГРС - ЗАГС по (ПИН)',
  passportDataByPSN: 'ГРС - Паспортные данные',
  zagsPinsByNSPDate: 'ГРС - Сведения о ПИН',
  foreignByDocRequest: 'ГРС - Cведения об иностранных гражданах',
  getsubjectbyname: 'Минюст - Сведения о рег. юр. лица по наименованию',
  getsubjectbytin: 'Минюст - Сведения о юр. лице по ИНН',
};
export {ENTITY_NAMES};
