using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace question2
{
    class Postfix
    {
        static bool IsOperator(char c)
        //Checks to see what operators are used
        {

            //Checks if operator is +
            if (c == '+')
                return true;
            //Checks if operator  is -
            if (c == '-')
                return true;
            //Checks if operator is *
            if (c == '*')
                return true;
            //Checks if operator is /
            if (c == '/')
                return true;
            //Checks if operator is ^
            if (c == '^')
                return true;
            //Checks if operator is %
            if (c == '%')
                return true;

            else
                return false;

        }

        //Method to assess and see the priority of the operator
        static int Precedence(char c)
        {

            //Checks if the operator is a plus or minus, This operator will have the least priority
            if (c == '+' || c == '-')
                return 0;

            //Check if it is a times or divide. This has Medium priority
            if (c == '*' || c == '/')
                return 1;
            //Check to see if it is a exponentiation or modulus operator. This has High priority
            if (c == '^' || c == '%')
                return 2;
            return 3;
        }


        //Method for converting from infix to postfix 

        public static StringBuilder
        ConvertToPostfix(StringBuilder inf)
        {
            //Stack that handles the converting process 
            Stackinheritance stin = new Stackinheritance();


            //String that holds the expression  
            StringBuilder postf = new StringBuilder();

            // loop that runs till the end of the expression
            for (int j = 0; j < inf.Length; j++)
            {
                //Gets the character that is to be processed
                char ch = inf[j];

                //Checks weather the character is a operator or not by using the IsOperator method 
                if (IsOperator(ch))
                {
                    //Checks if the string is not empty
                    if (!stin.IsEmpty())
                    {

                        //Pops the chacter from the stack 
                        char ch1 = (char)stin.Pop();

                        //Checks to see if the character is a operator. 
                        if (IsOperator(ch1))
                        {
                            //See if the character has a greater precedence than the one previousily selected 
                            if (Precedence(ch) >
                                Precedence(ch1))
                            {
                                //Puts the character into the stack 
                                stin.Push(ch1);

                                stin.Push(ch);



                            }
                            else if (Precedence(ch) == Precedence(ch1))

                            {
                                //Insert the first charater into the stack 
                                stin.Push(ch1);

                                //Insert into expression
                                postf.Append
                                    (ch1.ToString());
                            }
                            else

                            {
                                //Insert character into stack untill the loop is empty
                                stin.Push(ch1);
                                while (!stin.IsEmpty())
                                {
                                    //Remove character from stack
                                    ch1 = (char)stin.Pop();
                                    if (ch1 == '(')

                                        break;
                                    stin.Push(ch1);

                                    //Take character from the stack and add it to the expression

                                    postf.Append((stin.Pop()).ToString());
                                }

                                stin.Push(ch);

                            }
                        }
                        //Insert character into stack
                        else stin.Push(ch);
                    }
                    //Insert chartacter into stack
                    else stin.Push(ch);
                }
                //Checks if the character is a (
                else if (ch == '(')

                    stin.Push(ch);
                //Checks if the character is a )
                else if (ch == ')')
                {
                    char ch1;
                    //Run the loop while the stack is empty
                    while (!stin.IsEmpty())
                    {
                        //check to see if the stack is null
                        if (stin != null)
                        {
                            //Remove character from the stack
                            ch1 = (char)stin.Pop();

                            //Check if the character is a (
                            if (ch1 != '(')
                                postf.Append(ch1.ToString());
                        }
                    }
                }
                else

                {
                    //Add the character to the expression
                    postf.Append(ch.ToString());
                }
            }
            //Run loop untill the stack is empty 
            while (!stin.IsEmpty())

            {
                if (stin != null)
                    //Remove character from the stack and add it to the expression
                    postf.Append(stin.Pop().ToString());
            }
            //Return the expression
            return postf;
        }
    }

    //Class that tests the application
    class InfixToPostfixConverter : Postfix
    {
        static void Main(string[] args)
        {
            //Strings to accumudate the expressions
            StringBuilder postf = new StringBuilder();
            StringBuilder exp = new StringBuilder();

            //The expression that is to be converted
            String s;
            Console.WriteLine("");

            Console.WriteLine("Infix to Postfix");
            Console.WriteLine("/n");

            //Ask the user to input a expression that they want to convert 
            Console.WriteLine("Enter an expression");

            s = Console.ReadLine();
            exp.Append(s.ToString());
            //The method that is used to convert the expression 
            postf = ConvertToPostfix(exp);

            Console.WriteLine("inFix :\t" + postf);

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

