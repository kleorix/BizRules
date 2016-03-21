using BusinessRulesHelper.BusinessRules.Interfaces;

namespace BusinessRulesHelper.BusinessRules.ValidatorResults {
    public class GeneralResult : IValidatorResult {
        public bool IsValid { get; set; }
        public string NotificationMessage { get; set; }
        public string ErrorMesage { get; set; }
        public string WarningMesage { get; set; }
    }
}
