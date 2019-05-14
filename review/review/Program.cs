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

            //using instances of classes
            Console.WriteLine("\n Entering Gate Data \n");

            string menItem = "0";

            FenceEstimate CustomerFence = new FenceEstimate();
            CustomerFence.Fence = newvariable;
            CustomerFence.Gates = null;
            Gate theGate = null;

            string inputValue;

            do
            {
                theGate = new Gate();
                Console.Write("Height: ");
                inputValue = Console.ReadLine();
                theGate.Height = double.Parse(inputValue);

                Console.Write("Width: ");
                inputValue = Console.ReadLine();
                theGate.Width = double.Parse(inputValue);

                Console.Write("Style: ");
                inputValue = Console.ReadLine();
                theGate.Style = inputValue;

                Console.Write("Price: ");
                inputValue = Console.ReadLine();
                if (string.IsNullOrEmpty(inputValue))
                {
                    theGate.Price = null;
                }
                else
                {
                    theGate.Price = Double.Parse(inputValue);
                }

                //the local instance of gate needs to be saved 
                // into teh FenseEstimate
                CustomerFence.Gates.Add(theGate);

                Console.Write("Add another gate (Y or N): ");
                inputValue = Console.ReadLine();
                menItem = inputValue.ToUpper().Equals("Y") ? "1" : "0";


            } while (menItem != "0");

            Console.WriteLine("Style: ");
            inputValue = Console.ReadLine();
            double linearLenth = double.Parse(inputValue);

            //using the customer fence data calculate the cost
            double numberOfPanels = CustomerFence.Fence.EstimatedNumberOfPanels(linearLenth);
            double fencePrice = Math.Ceiling(numberOfPanels) * double.Parse(CustomerFence.Fence.Price.ToString());
            double gatecost = 0.0;  
            foreach(Gate item in CustomerFence.Gates)
            {

                gatecost += double.Parse(CustomerFence.Fence.Price.ToString()); 
            }
            Console.WriteLine("Total Fence Estimate");
            Console.WriteLine("Number of panels: " + numberOfPanels.ToString());
            Console.WriteLine("Cost of panels:" + fencePrice.ToString());
            Console.WriteLine("Number of gates: " + CustomerFence.Gates.Count.ToString());
            Console.WriteLine("Cost of Gates: " + gatecost.ToString());
            Console.WriteLine("Total: " + (fencePrice + gatecost).ToString());
            Console.ReadLine();
        }

    }
}
