using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    /// <summary>
    /// person is an object, but we dont objectify persons. 
    /// </summary>
    internal class person
    {
        public int thisyear = 2025;
        public int id;
        public string name;
        public int age;
        public string eyeColour;
        public int dob;

        //default construct method
        //public person() 
        //{
        //    id = 1;
        //    name = "bob";
        //    age = 30;        
        //}

        //fancy constructor (overload)
        //public person(int id, string name, int age)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.age = age;
        //}

        /// <summary>
        /// default constructor, this creates our object, has default values. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dob"></param>
        /// <param name="name"></param>
        /// <param name="eyeColour"></param>
        public person(int id = 1 , int dob = 1995 , string name = "bob", string eyeColour = "brown")
        {
            this.dob = dob;
            age = thisyear - dob;//solve for age
            this.id = id;
            this.name = name;
            this.age = age;
            this.eyeColour = eyeColour;
        }




    }
}
