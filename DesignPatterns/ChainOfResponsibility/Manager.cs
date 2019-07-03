using System;

namespace DesignPatterns.ChainOfResponsibilities
{
    //ConcreteHandler  class 
    class Manager : Approver
    {
        public override void ProcessRequest(Project Project)
        {
            if (Project.Amount < 10000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                this.GetType().Name, Project.Number);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(Project);
            }
        }
    }
}
