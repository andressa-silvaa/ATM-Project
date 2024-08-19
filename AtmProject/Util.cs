using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AtmProject
{
    internal class Util
    {
        public static bool ValidateAccountNumber(string accountNumber)
        {
            return Regex.IsMatch(accountNumber, @"^\d{5}$");
        }
        public static bool ValidateInteger(string input)
        {
            return int.TryParse(input, out _);
        }
        public static bool ValidatePin(string pin)
        {
            return Regex.IsMatch(pin, @"^\d{5}$");
        }

        public static bool ValidateName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\(?[1-9]{2}\)? ?9[6-9]\d{3}-?\d{4}$");
        }

        public static bool ValidateAddress(string address)
        {
            return !string.IsNullOrWhiteSpace(address);
        }

        public static bool ValidateEducation(string education)
        {
            return !string.IsNullOrWhiteSpace(education);
        }

        public static bool ValidateBirthDate(DateTime birthDate)
        {
            return birthDate < DateTime.Now;
        }

        public static bool IsOver18YearsOld(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now < birthDate.AddYears(age)) age--;
            return age >= 18;
        }
    }
}
