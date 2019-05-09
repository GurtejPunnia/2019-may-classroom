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
            // when this stattement is excuted , the default coneructer will be callded on your behave
            //
            FencePanel newvariable = new FencePanel();
            newvariable.Height = 5.8;
            newvariable.Width = 8.0;
            newvariable.Style = "Neighbour friendly";

            Console.WriteLine( "Height is: " + newvariable.Height.ToString());

            Console.WriteLine("Width is: " + newvariable.Width.ToString());

            Console.WriteLine("Style is: " + newvariable.Style);

            Console.WriteLine("Price is: " + newvariable.Price.ToString() + "\n");


            //if you use a new command with the class
            // the new command will phtically create an instance of class
            // when this stattement is excuted , the default coneructer will be callded on your behave
            //
            FencePanel newvariable1 = new FencePanel(4.0, 6.8, "private", 32.89);

            Console.WriteLine("Height is: " + newvariable1.Height.ToString());

            Console.WriteLine("Width is: " + newvariable1.Width.ToString());

            Console.WriteLine("Style is: " + newvariable1.Style);

            Console.WriteLine("Price is: " + newvariable1.Price.ToString() + "\n");


            Console.ReadLine();
        }

    }
}
