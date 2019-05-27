using System;
using OopLearning.BL;

namespace TestLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Morten Juul";
            Console.WriteLine(person.Name);
            person.Cpr = "2108761353";
            Console.WriteLine(person.Cpr);
            Console.WriteLine(person.Birthday.ToShortDateString());
            Console.WriteLine(person.IsWoman);
        }
    }
}
