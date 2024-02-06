using System.Text.RegularExpressions;

namespace FutebolPrimeGestor.Domain.Entities.Validations.ValidationDocs
{
    public class NumeroCelularValidation
    {
        private readonly NumeroCelularValidationOptions _validationOptions;

        private static readonly Regex _defaultFormat = new Regex(@"^(?:(?:\+?55)?[ .-]*\(?0?[1-9][0-9]\)?)[ .-]?(?:(?:(?:9[ .-]*)?[0-9]{4})[ .-]*[0-9]{4})$");

        public NumeroCelularValidation(NumeroCelularValidationOptions validationOptions)
        {
            _validationOptions = validationOptions;
        }

        public NumeroCelularValidation()
        {
            _validationOptions = new NumeroCelularValidationOptions();
        }

        public bool Validate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            Regex formatToApply;
            if (_validationOptions.Format != null)
            {
                formatToApply = HandleCustomFormat(_validationOptions.Format);

                return formatToApply.IsMatch(value);
            }

            formatToApply = SetFormatBaseOnOptions(_validationOptions);
            return formatToApply.IsMatch(value);
        }

        private static Regex HandleCustomFormat(string customFormat)
        {
            var regex = new Regex(@"[0-9]+");
            var phonePattern = Regex.Replace(customFormat, @"[0-9,?]+", m =>
            {
                var optionalsCount = m.Value.Split(new char[] { '?' }).Length - 1;
                var stringRegex = "";
                if (optionalsCount != 0)
                {
                    stringRegex += (m.Length - optionalsCount);
                    stringRegex += ",";
                    stringRegex += (optionalsCount + (m.Length - optionalsCount));
                }
                else
                {
                    stringRegex = m.Length.ToString();
                }
                return $@"\d{{{stringRegex}}}";
            });
            phonePattern = @"^" + Regex.Replace(phonePattern, @"(?:(?(1)(?!))(\+)|(?(2)(?!))(\()|(?(3)(?!))(\)))+", m => $@"\{m.Value}").Replace("-", @"\-").Replace(" ", @"\s") + "$";
            return new Regex(phonePattern);
        }

        private static Regex SetFormatBaseOnOptions(NumeroCelularValidationOptions phoneOptions)
        {
            if (phoneOptions.CellPhonesOnly && phoneOptions.StrictNineDigit)
            {
                return new Regex(@"^(?:(?:\+?55)?[ .-]*\(?0?[1-9][0-9]\)?)[ .-]?(?:(?:(?:9[ .-]*)[0-9]{4})[ .-]*[0-9]{4})$");
            }

            if (phoneOptions.CellPhonesOnly && !phoneOptions.StrictNineDigit)
            {
                return new Regex(@"^(?:(?:\+?55)?[ .-]*\(?0?[1-9][0-9]\)?)[ .-]?(?:(?:(?:9[ .-]*)[0-9]{4}|[8-9][0-9]{3})[ .-]*[0-9]{4})$");
            }

            if (!phoneOptions.CellPhonesOnly && phoneOptions.StrictNineDigit)
            {
                return new Regex(@"^(?:(?:\+?55)?[ .-]*\(?0?[1-9][0-9]\)?)[ .-]?(?:(?:9[ .-]*[0-9]{4}|[1-7][0-9]{3})[ .-]*[0-9]{4})$");
            }

            return _defaultFormat;
        }
    }

    public class NumeroCelularValidationOptions
    {
        public bool StrictNineDigit { get; set; }
        public bool CellPhonesOnly { get; set; }
        public string? Format { get; set; }
    }
}
