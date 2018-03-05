using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Registration.ValidationRules
{
    public class NameFieldValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return new ValidationResult(!string.IsNullOrWhiteSpace(value.ToString()), string.Empty);
        }
    }
}
