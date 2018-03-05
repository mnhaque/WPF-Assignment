using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Registration.ValidationRules
{
    public class DateValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            DateTime date;
            return new ValidationResult(DateTime.TryParse(value.ToString(), out date), string.Empty);
        }
    }
}
