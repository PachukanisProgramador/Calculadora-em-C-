using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Control
    {
        Model model;
        double num1;
        double num2;
        int option;

        public Control()
        {
            model = new Model();
            num1 = 0;
            num2 = 0;
            option = 0;
        }


        public void Menu()
        {

            Console.WriteLine("|| CALCULATOR ||\nNumber 1:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            OperationChoose();

            if (option < 1 || option > 4)
            {
                do
                {


                    Console.Clear();

                    Console.WriteLine("Incorrect option!\n");

                    OperationChoose();

                } while (option < 1 || option > 4);
            }

            Console.WriteLine("\nNumber 2:");
            num2 = Convert.ToDouble(Console.ReadLine());

            OperationSwitch(option);

        }

        public void OperationChoose()
        {

            Console.WriteLine("\nOperation:\n|| 1.Sum | 2.Subtract | 3.Divide | 4.Multiply ||\n");
            option = Convert.ToInt32(Console.ReadLine());

        }

        public void OperationSwitch(int option)
        {

            switch (option)
            {
                case 1:

                    Console.Clear();

                    Console.WriteLine($"\n{num1} + {num2} = {model.Sum(num1, num2)}\n");

                    break;
                case 2:

                    Console.Clear();

                    Console.WriteLine($"\n{num1} - {num2} = {model.Subtract(num1, num2)}\n");

                    break;
                case 3:

                    Console.Clear();

                    Console.WriteLine($"\n{num1} % {num2} = {model.Divide(num1, num2)}\n");

                    break;
                case 4:

                    Console.Clear();

                    Console.WriteLine($"\n{num1} X {num2} = {model.Multiply(num1, num2)}\n");

                    break;

                default:

                    Console.Clear();

                    Console.WriteLine("Incorrect option!\n\n");

                    OperationChoose();

                    break;

            }

            Menu();
        }

    }
}
