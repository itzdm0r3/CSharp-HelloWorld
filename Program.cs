using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    static class Program 
    {
                
        //The main entry point for the application.
        static void Main()
        {
            //METHOD 1:
            //You can use classes to tidy up and modularize your code. This makes it easier to reuse than the second method
            //which hard codes the string "Hello World!" into the application

            //call the HelloWorld Greeting method from its class and display it on the console screen.
            Console.WriteLine(HelloWorld.Greeting());


            //METHOD 2:
            //An example of hard coding the "Hello World!" string. It is fewer lines of code but
            //it is not as modular.

            Console.WriteLine("\nHello World Again!");

        }
    }    
}