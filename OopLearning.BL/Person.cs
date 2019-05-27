using System;

namespace OopLearning.BL
{
    public class Person
    {
        private string name;
        private string cpr;

        public string Cpr {
            get => cpr;
            set
            {
                var cprCheck = ValidateCpr(value);
                if (cprCheck.isValid)
                {
                    cpr = value;
                }
                else
                {
                    throw new ArgumentException(cprCheck.errMessage, nameof(cpr));
                }
            }
        }
        public DateTime Birthday {
            get
            {
                DateTime.TryParse(Cpr.Substring(0, 2) + "-" + Cpr.Substring(2, 2) + "-" + Cpr.Substring(4, 2), out DateTime convertedCpr);
                return convertedCpr;
            }
        }
        public bool IsWoman {
            get
            {
                if ((int.Parse(Cpr.Substring(9,1)) % 2) > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public Person ()
        {

        }
        public Person(string name, string cpr)
        {
            Name = name;
            Cpr = cpr;
        }

        public string Name {
            get => name;
            set
            {
                var nameCheck = ValidateName(value);
                if (nameCheck.IsValid)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException(nameCheck.errMsg, nameof(name));
                }
            }
        }

        public static (bool IsValid, string errMsg) ValidateName(string name)
        {
            if (name is null)
            {
                return (false, "Navnet er tomt. Husk og udfyld det");
            }

            name = name.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                return (false, "Navnt består kun af white spaces");
            }

            if (!name.Contains(' '))
            {
                return (false, "Du ser ud til ikke og havde et efternavn, husk at udfylde det fulde navn");
            }

            if (name.Length < 1)
            {
                return (false, "Navnet skal være mere end 1 bogstav langt");
            }

            return (true, "");
        }

        public static (bool isValid, string errMessage) ValidateCpr(string cpr)
        {
            if (cpr is null)
            {
                return (false, "cpr er tomt, husk og udfyld den");
            }
            
            if (cpr.Length != 10)
            {
                return (false, "cpr er ikke udfylt korrekt, formatet skal være dagmånedårdesidstefire eks: 2108765785");
            }

            if (int.Parse(cpr.Substring(0,2)) < 1 || int.Parse(cpr.Substring(2, 2)) > 31)
            {
                return (false, "de 4 første tal er ikke en gyldig fødselsdato");

            }

            if (int.Parse(cpr.Substring(4, 2)) < 0 || int.Parse(cpr.Substring(4, 2)) > 99)
            {
                return (false, "års talet er ikke en gyldig fødselsdato");
            }

            if (DateTime.Parse(cpr.Substring(0, 2) + "-" + cpr.Substring(2, 2) + "-" + cpr.Substring(4, 2)) > DateTime.Today)
            {
                return (false, "det cpr er ude i fremtiden, det dutter ikke");
            }

            return (true, "");
        }

    }
}
