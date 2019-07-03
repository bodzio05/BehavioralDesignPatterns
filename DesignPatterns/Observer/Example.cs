using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public static class Example
    {
        public static void Execute_Example()
        {
            //Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("kokan"));
            ibm.Attach(new Investor("maobi"));

            //Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.0;
            ibm.Price = 121.0;
            ibm.Price = 122.75;
            ibm.Price = 120.25;


            // Wait for user
            Console.ReadKey();
        }
    }
}
