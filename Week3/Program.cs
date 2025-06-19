using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //lets say hello guys            
            Console.WriteLine("Hello, RB here!");



            //recap
            //1. lets list some variables
            bool b;
            float f;
            int i;
            string s; //{s,t,r,i,n,g}
            //char c;



            //2. recap challenges!!! NO CHATGPT OR AI!!!

            //a) ask the user to input 2 numbers into the console
            Console.WriteLine("Enter a Number for x:");

            s = Console.ReadLine();
            int x = int.Parse(s);
            Console.WriteLine("Enter a Number for y:");
            s = Console.ReadLine();
            int y = int.Parse(s);

            //b) multiply the 2 numbers together, then output to console

            Console.WriteLine(x*y);

            //c) lets check if the new number is even or odd (difficulty level 8) use google or look at last weeks code. then comment a short explanation how it works.

            //modular divide the number then gives us the remainder. we are then seeing if the remained is equal to 0
            if (x * y % 2 == 0)
            {
                Console.WriteLine("its even!");
            }
            else { Console.WriteLine("its odd!"); }

            //d) here's one for math people, if Y=mx+c, lets ask for 3 variables,
            //      then we solve for Y and output to console (difficulty level 9)

            double M;
            double X;
            double C;
            Console.WriteLine("Enter for (m):");
            M = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter for (x):");
            X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter for (c):");
            C = Convert.ToDouble(Console.ReadLine());

            double Y = (M * X) + C;

            Console.WriteLine($"\nResults:");
            Console.WriteLine($"Y = {M} * {X} + {C} = {Y}");

            //e) explain what pseudo code is? (may not be covered already, but lets see who knows?)
            //not proper code, explained. shorthand aswell, explainning steps. 


            //f) anyone want to codeflex? share something they found interesting?



            //Decision control
            //who can explain this?


            // if, else, else if
            //rb will demonstate this. (cats and dogs) 


            bool likesCats = false;
            bool likesDogs = true;


            if (likesCats && likesDogs)
            {
                Console.WriteLine("Likes both cats and dogs");
            } else if (likesCats && !likesDogs) //likes cats and doesnt like dogs
            {
                Console.WriteLine("likes only cats");
            }
            else if (likesDogs)
            {
                Console.WriteLine("likes only dogs");
            }
            else
            {
                Console.WriteLine("this person is a sociopath, doesnt like dogs or cats!!!");
                Console.WriteLine("possible serial killer, watch out!!!");
            }


            //nesting, 
            if (likesCats || likesDogs)
            {
                if (likesCats && likesDogs)
                {
                    Console.WriteLine("likes both");
                }
                else if (likesCats) //likes cats and doesnt like dogs
                {
                    Console.WriteLine("likes only cats");
                }
                else
                {
                    Console.WriteLine("likes only dogs");
                }

            }            
            else
            {
                Console.WriteLine("this person is a sociopath, doesnt like dogs or cats!!!");
                Console.WriteLine("possible serial killer, watch out!!!");
            }







            //3) your tasks (be creative!!!)

            //a) pineapple on pizza, only 2 options, (pineapple doesnt go on pizza, if you think so you're wrong)

            //Jenna

            string opinion = "No";
            Console.WriteLine("Does Pinapple belong on Pizza?");

            if (opinion == "Yes")
            {
                Console.WriteLine("\nYou are an odd individual. But I respect you");
            }
            else if (opinion == "No")
            {
                Console.WriteLine("\nYou are secretly right, but we wont say anything to anyone");
            }

            Console.WriteLine("\nPress any key to exit. . .");
            Console.ReadKey();

            //b) what cpu brand do you have? intel or amd? get creative with this solution, maybe ask the user?

            //c) create a if/else/else if decision control around 1 of your interests (cant be PC related. everyone hear clearly likes pc's or gaming)


            Console.WriteLine("Do you like team sports? Answer Y/N:");
            string Answer = Console.ReadLine();            

            if (Answer.ToLower() == "yes" || Answer.ToLower() == "y")
            {
                Console.WriteLine("You team player you");
            }
            else 
            {
                Console.WriteLine("Wow, you suck");
            }

                //d) try and create a if/else statement using && or || operators. 



                //switch case and enum
                //explain what and why? advantages and disadvantages??



                //rb will demonstrate one (0-6) 


                //have a go at creating a switch based around 1 of your intersts. same task parameters as 3c

                //




                // Q&A time, next week hook, 



                //loops, nested loops, arrays and lists. 



            }
    }
}
