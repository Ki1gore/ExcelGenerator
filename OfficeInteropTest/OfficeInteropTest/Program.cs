using GeneratedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OfficeInteropTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratedClass gc = new GeneratedClass();
            gc.CreatePackage(@"C:\GeneratedSpreadsheets\out.xlsx");
        }
    }
}
