using System;

namespace DesignPatterns.ChainOfResponsibilities
{
    public static class Example
    {
        public static void Execute_Example()
        {
            Approver Sameer = new President();
            Approver Abhi = new CEO();
            Approver Rahul = new Manager();

            Rahul.SetSuccessor(Sameer);
            Sameer.SetSuccessor(Abhi);



            // Generate and process purchase requests
            Project p = new Project(3333, 350.00, "Test Postponed");
            Rahul.ProcessRequest(p);
            p = new Project(5353, 32590.10, "Annual Function");
            Rahul.ProcessRequest(p);
            p = new Project(2036, 122100.00, "Renovation of Classes");
            Rahul.ProcessRequest(p);

            Console.ReadKey();
        }
    }
}
