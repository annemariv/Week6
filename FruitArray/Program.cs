﻿using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis puuvilja kasutaja sööb

            string[] fruit = new string[5] {"an apple", "a banana", "a lemon", "an orange", "some grapes"};

            //Console.WriteLine(fruit[0]);
            //Console.WriteLine(fruit[1]);
            //jne

            //Console.WriteLine("enter a number from 0 to 4:"); saab ise valida numbri

            Random rnd = new Random();

            int userNumber = rnd.Next(0,5);
                //Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Today you will have {fruit[userNumber]}.");
        }
    }
}