namespace Week5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //write our hellos
            Console.WriteLine("hello everyone!!!");



            //refresh on past weeks
            //week2, variables
            //week3, logic (if, else, else if, switch)
            //week4, loops

            //this week: functions


            //structure of functions, naming strategies

            //how we call and use functions

            //what is a return

            //practice some functions


            AddNumber();

            int i = AddNumber(3,4);

            float f = AddNumber(15.0f,16.0f);

            Console.WriteLine(f);

            //peoples();

            i = FibonacciSequence(0, 1,1);

            Console.WriteLine(i);

           


        }


        static void peoples()
        {

            person Bob = new person();

            Console.WriteLine(Bob.id);
            Console.WriteLine(Bob.age);
            Console.WriteLine(Bob.name);


            person Brett = new person(2, 1984, "Brett", "Blue");
            Console.WriteLine(Brett.name);
            Console.WriteLine(Brett.id);
            Console.WriteLine(Brett.eyeColour);
            Console.WriteLine(Brett.age);

            person Riley = new person(3, 1995, "Riley");

            Console.WriteLine(Riley.name);
            Console.WriteLine(Riley.id);
            Console.WriteLine(Riley.eyeColour);
            Console.WriteLine(Riley.age);

        }

        static void AddNumber()
        {
            int i = 3;
            int j = 4;

            Console.WriteLine(i+j);
        }

        //overload
        static int AddNumber(int i, int j)
        {
            //formatting inputs and outputs
           return (int)AddNumber((float)i,(float) j);
        }

        static float AddNumber(float i, float j)
        {
            return i + j;
        }

        //recursive function


        static int FibonacciSequence(int depth, int i, int j)
        {
            //we need a way to break, we're using depth
            if (depth == 15)
                return j;

            int k = i + j;

            Console.WriteLine(k);   

            return FibonacciSequence(depth + 1, j,k);                    
        }







    }
}
