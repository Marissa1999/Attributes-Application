using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{


    class CustomAttribute : Attribute
    {
     
        public CustomAttribute(string message, bool error)
        {
            Message = message;
            IsError = error;
        }

        public string Message { get; }
        
        public bool IsError { get; }

    }

    //This class can be saved to disk.
    [Serializable, ObsoleteAttribute("Use Car Class Instead", false)]
    [CustomAttribute("My Message", false)]

    public class Motorcycle
    {
        //However, this field will not be persisted.
        [NonSerialized]
        float weightOfCurrentPassengers;
        //These fields are still serializable.
        bool hasRadioSystem;
        bool hasHeadSet;
        bool hasSissyBar;
    }

    class Program
    {
        static void Main(string[] args)
        {

            Motorcycle m = new Motorcycle();
            m.ToString();

        }
    }
}
