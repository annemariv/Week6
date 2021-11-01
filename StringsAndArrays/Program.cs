using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm kuvab kasutaja eesnime pikkuse

            Console.WriteLine("sisesta eesnimi");
            string firstName = Console.ReadLine();

            int firstNameLenght = firstName.Length; //ilma in firstname on ka võimalik
            Console.WriteLine($"Sinu eesnimes on {firstNameLenght} sümbolit.");

        }
    }
}
