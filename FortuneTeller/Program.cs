using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis kasutajaga juhtub homme (kasutame Random klassi)

            string[] predictions = { "win a million", "fall in love", "buy youtube premium", "join the darkside for cookies" };

            Random rnd = new Random();

            int userrnd = rnd.Next(0, 5);
            

            Console.WriteLine($"Tomorrow you will {predictions[userrnd]}.");
        }
    }
}
