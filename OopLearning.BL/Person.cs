using System;

namespace OopLearning.BL
{
    public class Person
    {
        private string name;
        private string cpr;

        public string Cpr { get => cpr; set => cpr = value; }
        public DateTime Birthday {
            get
            {
                
                return Birthday;
            }
        }
        public bool IsWoman { get; }

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


    }
}
