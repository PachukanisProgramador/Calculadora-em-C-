using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Control control = new Control();

                control.Menu();

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n\nSomething went wrong!\n\n{e}");
                throw;
            }




        }
    }
}
