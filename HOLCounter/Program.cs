using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            //Console.WriteLine("Palun sisesta lause: Hello World!");
            string HelloWorld = "Hello World!".ToLower();
                //Console.ReadLine().ToLower();
            

            

            Console.WriteLine(HelloWorld);

            int hCounter = 0;

            for (int i = 0; i < HelloWorld.Length; i++)
            {
                

                if (HelloWorld[i] == 'h') 
                {
                    hCounter++;
                }
            }
            if (hCounter != 1)
            {  

                Console.WriteLine($"Lauses on {hCounter} 'h' tähte.");
            }
            else
            {

                Console.WriteLine($"Lauses on {hCounter} 'h' täht.");
            }


            int oCounter = 0;

            for (int i = 0; i < HelloWorld.Length; i++)
            {


                if (HelloWorld[i] == 'o') 
                {
                    oCounter++;
                }
            }
            if (oCounter != 1)
            {

                Console.WriteLine($"Lauses on {oCounter} 'o' tähte.");
            }
            else
            {

                Console.WriteLine($"Lauses on {oCounter} 'o' täht.");
            }


            int lCounter = 0;

            for (int i = 0; i < HelloWorld.Length; i++)
            {


                if (HelloWorld[i] == 'l')
                {
                    lCounter++;
                }
            }
            if (lCounter != 1)
            {

                Console.WriteLine($"Lauses on {lCounter} 'l' tähte.");
            }
            else
            {

                Console.WriteLine($"Lauses on {lCounter} 'l' täht.");
            }
        }
    }
}
