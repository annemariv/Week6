﻿using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kuvab, mitu 'a' tähte on kasutaja ees- ja perekonnanimes kokku

            Console.WriteLine("sisesta eesnimi");
            string firstName = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                //Console.WriteLine(firstName[i]);

                if (fullName[i] == 'a') //char a = 'a';
                {
                    aCounter++;
                }
            }
               if(aCounter != 1)
               {
                //Console.WriteLine($"Sinu eesnimes {firstName} on {aCounter} 'a' tähte.");

                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
               }
                else
                { 
                  //Console.WriteLine($"Sinu eesnimes {firstName} on {aCounter} 'a' täht.");

                  Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' täht.");
                }
            
        }
    }
}
