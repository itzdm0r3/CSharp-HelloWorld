using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //created a new class for our Hello World program.
    internal class HelloWorld
    {
        //create a method that produces the string "Hello World!".

        public static string Greeting()    //the method is static so that a "new" instance of the class 
                                           //isn't needed to access this method.
        {
            return "Hello World!";
        }

    }
}
