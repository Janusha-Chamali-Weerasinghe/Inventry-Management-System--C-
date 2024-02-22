using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    class Reg_validation
    {

        public bool Username_validate(string txtvalue)   // UserName Validation
        {
            bool isValidate = true;
            Regex Rx1 = new Regex(@"^[A-z][A-z|\.|\s]+$");
            if (!Rx1.IsMatch(txtvalue))
            {
                isValidate = false;
            }
            return isValidate;
        }

        public bool Password_validate(string txtvalue)   // Password Validation
        {
            bool isValidate = true;
            Regex Rx2 = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (!Rx2.IsMatch(txtvalue))
            {
                isValidate = false;
            }
            return isValidate;
        }
        public bool TelephoneNumber_validate(string txtvalue)   // TelePhone Number Validation
        {
            bool isValidate = true;
            Regex Rx3 = new Regex("^[0-9]{10}$");
            if (!Rx3.IsMatch(txtvalue))
            {
                isValidate = false;
            }
            return isValidate;
        }

        public bool Address(string txtvalue)  // Address Validation 
        {
            bool isValidate = true;
            Regex Rx4 = new Regex("^[a-z A-Z 0-9'-,/]{5,}$");
            if (!Rx4.IsMatch(txtvalue) || string.IsNullOrWhiteSpace(txtvalue))
            {
                isValidate = false;
            }
            return isValidate;
        }

        

            public bool Description(string txtvalue)  // Description Validation 
        {
            bool isValidate = true;
            Regex Rx4 = new Regex(@"^(?!\s*$).+");
            if (!Rx4.IsMatch(txtvalue) || string.IsNullOrWhiteSpace(txtvalue))
            {
                isValidate = false;
            }
            return isValidate;
        }

        public bool Quantity(string txtvalue)  // Number limite 3.quantity 
        {
            bool isValidate = true;
            Regex Rx4 = new Regex("^[0-9]{0,3}$");
            if (!Rx4.IsMatch(txtvalue) || string.IsNullOrWhiteSpace(txtvalue))
            {
                isValidate = false;
            }
            return isValidate;
        }

        public bool FullName(string txtvalue)  // Full name with 4 parts with space Validation  
        {
            bool isValidate = true;
            Regex Rx4 = new Regex("^[a-zA-Z]{4,}(?: [a-zA-Z]+){0,4}$");
            if (!Rx4.IsMatch(txtvalue) || string.IsNullOrWhiteSpace(txtvalue))
            {
                isValidate = false;
            }
            return isValidate;
        }

        public bool Price(string txtvalue)  // Price minimum 2 digit and 2 decimal 2 digit Validation  
        {
            bool isValidate = true;
            Regex Rx4 = new Regex(@"^\d{2,8}(\.\d{1,2})?$");
            if (!Rx4.IsMatch(txtvalue) || string.IsNullOrWhiteSpace(txtvalue))
            {
                isValidate = false;
            }
            return isValidate;
        }

        public bool OneSpaceAndLettersOnly(string txtvalue)   // Only Letters With One Space Validation
        {
            bool isValidate = true;
            Regex Rx6 = new Regex("^[a-z A-Z]{3,}$");
            if (!Rx6.IsMatch(txtvalue) || string.IsNullOrWhiteSpace(txtvalue))
            {
                isValidate = false;
            }
            return isValidate;
        }
    }
}
