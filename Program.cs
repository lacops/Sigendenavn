using System;

namespace Sigendenavn
{
    class Program
    {
        static void Main(string[] args)
        {
            


        HelloWorld hello = new HelloWorld();
            hello.TextToShow = "Værdi";
            hello.Print();

            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
