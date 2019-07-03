using System;

namespace DesignPatterns.ChainOfResponsibilities
{
    class CEO : Approver
    {
        public override void ProcessRequest(Project Project)
        {
            if (Project.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                this.GetType().Name, Project.Number);
            }
            else
            {
                Console.WriteLine(
                "Request# {0} requires an executive meeting!",
                Project.Number);
            }
        }
    }
}
