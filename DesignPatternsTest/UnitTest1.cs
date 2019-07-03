using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChainOfResponsibility()
        {
            DesignPatterns.ChainOfResponsibilities.Example.Execute_Example();
        }

        [TestMethod]
        public void Commands()
        {
            DesignPatterns.Commands.Example.Execute_Example();
        }

        [TestMethod]
        public void Interpreter()
        {
            DesignPatterns.Interpreter.Example.Execute_Example();
        }

        [TestMethod]
        public void Iterator()
        {
            DesignPatterns.Iterator.Example.Execute_Example();
        }

        [TestMethod]
        public void Mediator()
        {
            DesignPatterns.Mediator.Example.Execute_Example();
        }

        [TestMethod]
        public void Memento()
        {
            DesignPatterns.Memento.Example.Execute_Example();
        }

        [TestMethod]
        public void Observer()
        {
            DesignPatterns.Observer.Example.Execute_Example();
        }
    }
}
