using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Methods_and_Classes
{
    static internal class UseFullTools
    {
        public static void sayHi(String name)
        {
            Console.WriteLine("Hi "+ name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(144));
            UseFullTools.sayHi("Sue");
            Console.ReadLine();
        }
    }
}
