namespace PASS_ISE102T2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world, This is Andrew");
            Console.WriteLine("Hello, RB here");
            Console.WriteLine("Hello! Jenna is present!");
            Console.WriteLine();
            Console.WriteLine("Hello, Sarah here");

            //explore variables
            //int, string, double, bool, char, float, 

            //var type, name of variable, assigned a value.
            string name = "Jenna";
            Console.WriteLine(name);          
            bool isLoggedIn = true;            
            int x = 23;

            //console out, "Jenn is X years old". x being 23
            //concatination. 
            Console.WriteLine($"Jenna is {x} years old");
            //Console.WriteLine("jenna is " + x + " years old"); the old way of doing this... eww its ugly, kind of similar to python

            //always increase by 1
            x++;
            Console.WriteLine($"new age: {x}");

            //what if we had an error when creating the age initially? 
            x = 30;
                        //casting
            float f = (float) x / 8.0f; //we can run multiple different formulas with math. 
            x = 8;
            bool isEven = x % 2 == 0; // we divide 8 by 2, splits into 4, 0 remainder
            // 0 == 0 , true
            bool isODD = x % 2 == 1;
            Console.WriteLine(isEven);

            x = 9001;
            bool greaterThan9000 = x > 9000; 
            Console.WriteLine(greaterThan9000);

            bool conditionalName = x > 9000 && isODD || isEven;

            //easy to read and maintain
            if (conditionalName)
            { 
                //do some tasks, Like not not !python with different words            
            }










            






        }
    }
}
