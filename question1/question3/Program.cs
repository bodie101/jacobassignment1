using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace question3
{
    public class MyQueue
    {
        public static void Main(string[] args)
        {
            //Array list and values
            ArrayList array = new ArrayList() { "A", "B", "C", "D", "E" };

            //Uses PrintQueue method to print array 
            Console.WriteLine("First Array");
            Console.WriteLine(PrintQueue(array));
            Console.ReadKey();

            //Uses Enqueue method to add character to the Array 
            Console.WriteLine("Array with F added to it");
            Console.WriteLine(EnQueue(array));
            Console.ReadKey();

            //Uses Dequeue method to take a character for the array
            Console.WriteLine("Array with A being removed");
            Console.WriteLine(DeQueue(array));

            Console.WriteLine();
            Console.WriteLine("thankyou for using this program");
            Console.ReadKey();

        }

        //Method to print the array 
        static string PrintQueue(ArrayList array)
        {

            StringBuilder sb = new StringBuilder();
            //Puts each item into sb
            foreach (var item in array)
                sb.Append(item);
            //returns sb to string
            return sb.ToString();
        }

        //Method to add character to Array 
        static string EnQueue(ArrayList array)
        {
            StringBuilder sb = new StringBuilder();
            //Adds F character to string builder
            array.Add("F");
            foreach (var item in array)
                sb.Append(item);
            //Prints string Builder to string
            return sb.ToString();

        }

        //Method to remove item from array 
        static string DeQueue(ArrayList array)
        {
            StringBuilder sb = new StringBuilder();
            //Removes the first character added to array which is A 
            array.Remove("A");
            foreach (var item in array)
                sb.Append(item);
            //Returns string builder with A Removed
            return sb.ToString();
        }
    }
}