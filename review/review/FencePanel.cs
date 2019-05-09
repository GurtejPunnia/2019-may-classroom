using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    //the default permission is private
    // if an outside user of this class wanted
    // access to the class contents; then
    // the access permission needs to be public.
    //if this class was static the class would not 
    // hold data.
    //For a class to hold data do not make  it static 
    // unless you want everyone to have access to that data (read and change).
    public class FencePanel
    {
        //properties
        //a property is asscoiated with a single piece of data
        // a propertity has two sub components
        //get: returns a value to the calling client

        // set: receives a value from calling client
        // the key word to represent incoming data is value
        //  property does not take a parameter;

        // there are two ways to code a property: fully implemented and auto implemented
        // auto-implemened property the property does not need 
        // a private data member to hold the actual data.
        // the data stroage will be managed by the system.
        public double Height { get; set; }
        public double Width { get; set; }

        //fully implemented property: the property will have a private data member to hold the actual data
        // usually, this coding form is used when additional 
        //logic/criteria is accociated with the data value.
        //since, the property will be doing some actions 
        // agianst the data, you must supply a storage area
        // this stroage area is referred to as a private data member;

        //private data member
        private string _Style;


        //fully implemeted property 
        public string Style
        {
            get
            {

                return _Style;

            }

            set
            {
                //value contain the incomming data to the property 
                // the contents of value to be stored 
                //criteria : do not store an empty string
                // store either null or the characters in the string
                if (string.IsNullOrEmpty(value))
                {
                    _Style = null;
                }
                else
                {
                    _Style = value;
                }
                
            }
        }
        //a nullable numeric(xxx?) will contain either a null or
        // a number
        // therefore nullbale numberics do not need to be fully implement unless you have additional criteria
        // to  cover 
        public double? Price { get; set;}

        //contructers
        //contructer(s) are executed for the client caller during 
        // the execution of the "new" Command
        // the client caller does not call a contructer directly
        // if no contructers are coded in a class defination 
        // then the data stroage within the class defination is set
        // to the system default (string -> null, numberics -> 0 bool -> false ...)
        //if one codes a contructer within the class defination
        // then the coder is reposible for alll contructers 
        // syntax public classname( list of parameters) {code }

        // there are two generally create contrcuter 
        // default: simulates the system default initailization of
        // youe data storage items using their datatype
        //greedy: this has a parameter list of all data strage items defined within the class defination

        //default

        public FencePanel()
        {
            //optionally you may wish to have your own value default 
            // values for your datat storage items
        }

        //GREEDY
        public FencePanel(double height, double width, string style, double? price)
        {

            Height = height;
            Width = width;
            Style = style;
            Price = price;

        }

        //behavior (aka method)
        public double EstimatedNumberOfPanels(double linearLength, double gateWidth, int numberOfGates)
        {
            double totalGateWidth = gateWidth * numberOfGates;
            double FenceWidth = linearLength - totalGateWidth;
            double numberOfPanels = FenceWidth / Width;
            return numberOfPanels;
        }

        

    }
}
