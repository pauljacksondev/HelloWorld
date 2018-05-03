using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine(MeToo.DoSomeCalling());

            Console.WriteLine(MeTooTwo.PrintToo()); 

        }
       
    }


    class MeToo
    {

        public static string DoSomeCalling()
        {
            string metoo = "Me Too!";
            return metoo;
        }

        

    }
}
