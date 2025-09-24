using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //public interface IPrinter
    //{
    //    void Print(string document);
    //}

    public class PrinterB : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printer B is working: '{document}'");
        }
    }
}
