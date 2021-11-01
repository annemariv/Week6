using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset ("Hello World!") tagurpidi

            //Console.WriteLine("sisesta lause: Hello World!");

            //string helloWorld = Console.ReadLine();
            string helloWorld = "Hello World";

            for (int i = helloWorld.Length - 1; i >= 0; i--)
            {
                Console.Write(helloWorld[i]);
            }
            
        }
    }
}
