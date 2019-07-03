using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    static class Program
    { 
        static void Main()
        {
            DesignPatterns.ChainOfResponsibilities.Example.Execute_Example();
            DesignPatterns.Commands.Example.Execute_Example();
            DesignPatterns.Interpreter.Example.Execute_Example();
            DesignPatterns.Iterator.Example.Execute_Example();
            DesignPatterns.Iterator2.Example.Execute_Example();
            DesignPatterns.Mediator.Example.Execute_Example();
            DesignPatterns.Memento.Example.Execute_Example();
            DesignPatterns.Observer.Example.Execute_Example();
            DesignPatterns.State.Example.Execute_Example();
            DesignPatterns.Strategy.Example.Execute_Example();
            //DesignPatterns.TemplateMethod.Example.Execute_Example();      //not working due to not configured database connection
            DesignPatterns.Visitor.Example.Execute_Example();
            Console.ReadLine();
        }
    }
}
