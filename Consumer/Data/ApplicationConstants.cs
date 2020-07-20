namespace Gkdr.Consumer.Data
{
    public static class ApplicationConstants
    {
        // Success Messages
        public const string SuccessRecordInserted = "Записи добавлены";
        public const string SuccessRecordDeleted = "Запись удалена";
        public const string SuccessRecordUpdates = "Изменения внесены";

        public const string SuccessPasswordChanged = "Пароль успешно изменен";
        
        
        // Errro Messages
        public const string ErrorRecordDuplicationFound = "Данные уже существуют";
        public const string ErrorModelValidation = "Ошибка в данных";
        public const string ErrorNotFound = "Запись не найден";

        public const string ErrorUserExist = "User Already Exist";
        public const string ErrorUserError = "Ошибка";
        public const string ErrorPasswordChanged = "Ошибка при смене пароля";
        public const string ErrorFileNotExist = "Файл не существует или был удален";
    }
}
