namespace BusinessRulesHelper.BusinessRules.Interfaces {
    public interface IValidatorResult {
        bool IsValid { get; set; }
        string NotificationMessage { get; set; }
        string ErrorMesage { get; set; }
        string WarningMesage { get; set; }
    }
}
