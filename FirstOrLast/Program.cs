using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("sisesta eesnimi");
            string firstName = Console.ReadLine();

            int firstNameLenght = firstName.Length; //ilma in firstname on ka võimalik
            Console.WriteLine($"Sinu eesnimes on {firstNameLenght} sümbolit.");

            Console.WriteLine("sisesta perekonnanimi");
            string lastName = Console.ReadLine();

            int lastNameLenght = lastName.Length; //ilma in firstname on ka võimalik
            Console.WriteLine($"Sinu eesnimes on {lastNameLenght} sümbolit.");

            if (firstNameLenght > lastNameLenght)
            {
                Console.WriteLine("Sinu eesnimi on pikem, kui perekonnanimi.");
            }
            else if (firstNameLenght < lastNameLenght)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem, kui eesnimi.");
            }
            else
            {
                Console.WriteLine("Ees- ja perekonnanimi on sama pikad.");
            }
        }
    }
}
