using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
   public class Gate
    {
        private string _Style;
        public double Height { get; set; }
        public double Width { get; set; }
        public double? Price { get; set; }

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
        public Gate()
        {
            //optionally you may wish to have your own value default 
            // values for your datat storage items
        }

        //GREEDY
        public Gate(double height, double width, string style, double? price)
        {

            Height = height;
            Width = width;
            Style = style;
            Price = price;

        }
        //read only property 
        //contains no set{}
        //data used in this protery is data that is currently
        // within the instance of this class
        public double GateArea
        {
            get
            {
                return Height * Width;
            }
        }
    }

}
