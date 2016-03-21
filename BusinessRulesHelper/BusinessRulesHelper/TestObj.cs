using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesHelper.BusinessRules.Interfaces;

namespace BusinessRulesHelper {
    public class TestObj:Product,IValidator {
        public IValidatorResult ValidatorProcessing(IValidatorOptions options) {
            throw new NotImplementedException();
        }
    }
}
