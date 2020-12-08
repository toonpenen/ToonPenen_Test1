using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToonPene_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaratie
            string naam;
            string Output;    
            int intNumber;
            long longNumber;
            float floatNumber;
            double doubleNumber;
            decimal decimalNumber;
            bool TrueOrFalse;
            DateTime dateTimeToday;
            #endregion
            #region Initiatie
            naam = "Toon";
            intNumber = 99;
            longNumber = 123456789;
            floatNumber = 1234.56789F;
            doubleNumber = -123456.123456D;
            decimalNumber = 1234315435435.12344564654564864M;
            TrueOrFalse = true;
            dateTimeToday = DateTime.Now;
            #endregion
            #region Output
            Output = $" string = { naam}"+
                     $" int = { intNumber}" +
                     $" long = { longNumber}" +
                     $" float = { floatNumber}" +
                     $" double = { doubleNumber}" +
                     $" decimal = { decimalNumber}" +
                     $" boolean = { TrueOrFalse}" +
                     $" datetime = { dateTimeToday}";
            #endregion
            Console.WriteLine(Output);            
        }
    }
}
