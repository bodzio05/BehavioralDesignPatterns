using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class NonTeamMember : Participant
    {
        // Constructor
        public NonTeamMember(string name): base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a non-TeamMember: ");
            base.Receive(from, message);
        }
    }
}
