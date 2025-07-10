using System.ComponentModel;

namespace Week6
{
    internal class Program
    {
        //entry point
        static void Main(string[] args)
        {
            //recap through previous sessions\
            // variables    
            // if,else, else if, logic switch
            // loops and arrays/lists
            // functions
            // custom objects, and OOP. 

            int i = AddNumber(3,4);

            customObject c = new("second object", 1, 32, 46, 7);

            //Console.WriteLine($"name: {c.name}");
            //Console.WriteLine($"X: {c.x}");
            //Console.WriteLine($"Y: {c.y}");
            //Console.WriteLine($"Z: {c.z}");
            //Console.WriteLine($"Radius: {c.radius}"); //default, we didnt specify anything in the arguments. 

            c.radius = 86;

            //Console.WriteLine($"Radius: {c.radius}");

            string colour = c.getColour();

            //Console.WriteLine(colour);

            colour = "red";

            //Console.WriteLine(colour);
            //Console.WriteLine(c.getColour());

            c.changeColour("brown");
            //Console.WriteLine(c.getColour());


            List<customObject> list = new List<customObject>();

            list.Add(c);
            list.Add(new customObject("third object",2,32,65));
            list.Add(new customObject("fourth object",3,49,78));
            list.Add(new customObject("fifth object",4,168,249));

            list[0].changeColour("black");
            list[1].changeColour("magenta");
            list[2].changeColour("cyan"); //not going to work, 5 letters or more. 
            list[3].changeColour("green"); //we dont like green 
            //list[4].changeColour("turqoise");


            //Console.WriteLine("\n\n\n Objects:");
            //foreach (customObject obj in list)
            //{ 
            //    Console.WriteLine(obj.getColour());
            //    Console.WriteLine(obj.name);
            //    Console.WriteLine($"X: {obj.x}\tY: {obj.y}\tZ: {obj.z}");
            //    Console.WriteLine($"{obj.radius}\n");            
            //}

            customObject newC = new("new object", 5, 68, 36, 42);
            distance(newC, list);



        }


        // accessbility, return type (object), Name ( parameteres containing more objects), 
        static int AddNumber(int number1, int number2)
        { 
            return number1 + number2;        
        }

        static void distance(customObject c, List<customObject> list)
        {
            float x = c.x;
            float y = c.y;
            float z = c.z;

            foreach (customObject obj in list)
            {
                if (obj.id == c.id)
                { continue; }
                float tempx = x - obj.x;
                float tempy = y - obj.y;

                float square = tempy * tempy + tempx * tempx;
                float m = MathF.Sqrt(square);
                Console.WriteLine($"distance = {m}");

            }
        }


    }




    public class customObject
    {
        //properties
        
        // circle
        //represents something?
        public string name;
        public int id;

        //positional data, x,y,z coordinates
        public float x;
        public float y;
        public float z;

        //radius
        public float radius;

        private string colour;
        

        /// <summary>
        /// default constructor.
        /// </summary>
        //public customObject()
        //{
        //    //object is going to have a default size of 1, starts at 0,0,0 (origin point)
        //    name = "first object of the day";
        //    id = 0;
        //    x = 0;
        //    y = 0;
        //    z = 0;
        //    radius = 1;
        //    colour = "yellow";
        //}
        /// <summary>
        /// custom constructor, give information
        /// </summary>
        public customObject(string name, int id, float x = 0, float y = 0, float z = 0, float radius = 1, string colour = "yellow")
        {
            this.name = name;
            this.id = id;
            this.x = x;
            this.y = y;
            this.z = z;
            this.radius = radius;
            this.colour = colour;
        }

        public string getColour()
        { 
        return colour; }


        public void changeColour(string newColour)
        {
           

            //i dont like the colour green. && string is shorter than 4 letters?
            if (newColour.ToLower() == "green" || newColour.Length <= 4)
            {
                return;            
            }
        
            colour = newColour;      
        }




    }

    //data structure 
    public struct customObject2 
    {
        public string name;
        public int id;
        public float x;
        public float y;
        public float z;       
            
    }
}
