using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    class Director:Employee
    {
        public Director() : base("Konrad", 35000.0, 16)
        {
        }
    }
}
