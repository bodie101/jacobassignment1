using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace question1
{

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Stack 
            Stack meStack = new Stack();

            // Get user input
            Console.WriteLine("Please, Input a string");
            string input = Console.ReadLine();
            // Pushs string into stack one character at a time backwards
            foreach (char c in input)
            {
                meStack.Push(c);
            }

            //ask user to press fullstop so the stack will print
            Console.WriteLine("Please, Press the fullstop key to print the stack");
            if (Console.ReadKey(true).Key == ConsoleKey.OemPeriod)
            {
                Console.Clear();
                // Delete a character from the stack
                Console.WriteLine("Please, Press the backspace key to delete a character");
                foreach (var v in meStack)
                {

                    Console.Write(v);


                }
            }


            //Delete character if backspace key is pressed 
            if (Console.ReadKey(true).Key == ConsoleKey.Backspace)
            {
                Console.WriteLine("\n");
                Method(meStack);
            }



        }

        //Method to Pop a character off the stack using the Pop attrubute 
        static void Method(Stack meStack)
        {
            Console.Clear();
            meStack.Pop();


            foreach (var v in meStack)
            {

                Console.Write(v); //Displays stack

            }

            Console.WriteLine();
            Console.WriteLine("Thankyou for viewing this program, Have a nice day!!");
            Console.ReadLine();

        }
    }
}


