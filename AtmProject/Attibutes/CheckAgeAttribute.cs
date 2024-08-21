using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmProject.Attibutes
{
    public class CheckAgeAttribute : ValidationAttribute
    {
        private readonly int _minimumAge;

        public CheckAgeAttribute(int minimumAge)
        {
            _minimumAge = minimumAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime dateOfBirth)
            {
                var age = DateTime.Today.Year - dateOfBirth.Year;
                if (dateOfBirth.Date > DateTime.Today.AddYears(-age)) age--;

                if (age < _minimumAge)
                {
                    return new ValidationResult(ErrorMessage ?? $"A idade deve ser pelo menos {_minimumAge} anos.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
