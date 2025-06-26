namespace Week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays, lists, loops, nesting

            int k = 5;

            int[] numbers = new int[k]; //array size of 5, 0-4 for indexing
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            //but we cant resize. 

            List<int> list = new List<int>();

            list.Add(36);

            int j = 42;
            list.Add(j);

            Console.WriteLine(list[0]);


            foreach (int i in numbers) 
            {
                Console.WriteLine(i);
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }


            //what type of loops do we have? we have 4 main types, 
            //what are they, how are they used. 

            //for loop, foreach, while, do while.
            //

            //iterating through a specific amount of times. 
            for (int i = 0; i < k; i++) 
            {
                Console.WriteLine(numbers[i] / 2);         
            }


            //andys code

            int counter = 0;
            //starting atleast once.
            do
            {
                Console.WriteLine("Counter is: " + counter);
                counter++; //add 1 to the counter
            }
            while (counter < 5); //we will continue loop until counter is equal to or more than 5. 

            //short do while loop


            //while loop
            //check condition before starting. 
            int count = 5;

            while (count < 5)
            {
                Console.WriteLine("Count is: " + count);
                count++;
                //if(true) //some condition
                //{ break; } //early exit
                
                //continue;
                //

            }


            // 
            int p = 3; int o = 2;

            int[,] matrix = new int[3, 2]
            {
                { 1, 2 },{ 3, 4 },{ 5, 6 }
            };

            bool found = false; 

            for (int i = 0; i < p; i++)            {

                for (int l = 0; l < o; l++)
                {

                    if (matrix[i, l] % 2 == 1)
                    {
                        continue;                        
                    }


                    if (matrix[i, l] == 6)
                    {
                        found = true;
                        Console.WriteLine($"x = {i} y = {l} value = {matrix[i, l]}");
                        break; //we found the variable that we were looking for. 
                    }

                    Console.WriteLine(matrix[i, l]);
                                        
                }
                if (found) break;
            }
            







        }
    }
}
