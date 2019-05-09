using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console is a reference to a system static class
            //static classes are used typing the class name
            //static classes do not store variable data
            //static classes are used by everyone
            //methods of a static class will be placed after 
            // the object dot operatator
            Console.WriteLine("Hello");
            

            //create an instance of a non static class
            //if you create a declarative using just the class name
            //then this is only a pointer that can hold an instance of the class
            //specified;
            //current value of aVariable is null

            FencePanel variable;

            //if you use a new command with the class
            // the new command will phtically create an instance of class

            FencePanel newvariable = new FencePanel();

            if(newvariable == null)
            {
                Console.WriteLine("newvariable is empty");
            }
            Console.ReadLine();
        }

    }
}
