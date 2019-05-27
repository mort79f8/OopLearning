using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL
{
    class Account
    {
        private string accountNumber;
        private string departmentNumber;
        private decimal balance;

        public string AccountNumber {
            get => accountNumber;
            set
            {
                var accountCheck = ValidateAccountNumber(value);
                if (accountCheck.IsValid)
                {
                    accountNumber = value;
                }
                else
                {
                    throw new ArgumentException(accountCheck.errMessage, nameof(accountNumber));
                }
            }
        }
        public string DepartmentNumber {
            get => departmentNumber;
            set
            {
                var departmentCheck = ValidateDepartmentNumber(value);
                if (departmentCheck.IsValid)
                {
                    departmentNumber = value;
                }
                else
                {
                    throw new ArgumentException(departmentCheck.errMessage, nameof(departmentNumber));
                }
            }
        }

        public decimal Balance {
            get => balance;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balancen kan ikke være negativ");
                }
                else
                {
                    balance = value;
                }
            }
        }

        public Account()
        {

        }
        public Account(string accountNumber, string departmentNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            DepartmentNumber = departmentNumber;
            Balance = balance;
        }

        private static (bool IsValid, string errMessage) ValidateAccountNumber(string value)
        {
            if (value is null)
            {
                return (false, "Account nummeret må ikke være tomt");
            }
            if (value.Length != 10)
            {
                return (false, "Account nummeret skal være 10 cifer langt");
            }
            return (true, "");
        }

        private static (bool IsValid, string errMessage) ValidateDepartmentNumber(string value)
        {
            if (value is null)
            {
                return (false, "Department nummer må ikke være tomt");
            }
            if(value.Length != 4)
            {
                return (false, "Department nummer skal være 4 cifer langt");
            }
            if(value.Substring(0,1) == "0")
            {
                return (false, "Department nummer må ikke starte med 0");
            }
            return (true, "");
        }
    }
}
