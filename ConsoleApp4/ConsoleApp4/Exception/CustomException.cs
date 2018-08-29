using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ConsoleApp4
{
    class Exception6
    {
        static void Main(string[] args)
        {
            try
            {
                // throw new FileNotFoundException("Erroe Message");
                //throw new CustomException();//We are not getting the message,so to get these functionality we should overload the constructor
                throw new CustomException();
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
    [Serializable]//it is breaking of object into different package and transferring over network,if want our class to work acoss application domain,
   // then make the class as seriallizable
    class CustomException : ApplicationException
    {
        public CustomException() : base()
        {
            //default constructor overloaded from the base class by base keyword
        }
        public CustomException(String Message) : base(Message) 
        {
           //args constructor overloaded from the base class by base keyword
        }
        public CustomException(String Message, Exception exception) : base(Message, exception)
        {
            //args constructor overloaded from the base class by base keyword
        }
        public CustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            //args constructor overloaded from the base class by base keyword
        }
    }
    
}

