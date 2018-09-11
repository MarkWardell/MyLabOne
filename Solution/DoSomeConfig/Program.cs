using System;
using System.Configuration;
namespace DoSomeConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName = ConfigurationManager.AppSettings["name"];
            string strAge  = ConfigurationManager.AppSettings["age"];
            Console.WriteLine(String.Format("Hello {0} you are {1} years old",strName,strAge));
            Console.ReadKey();
        }
        
    }
}
