using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public static class Example
    {
        public static void Execute_Example()
        {
            // Create chatroom
            Chatroom chatroom = new Chatroom();



            // Create participants and register them
            Participant George = new TeamMember("George");
            Participant Paul = new TeamMember("Paul");
            Participant Ringo = new TeamMember("Ringo");
            Participant John = new TeamMember("John");
            Participant Yoko = new NonTeamMember("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants
            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");

            // Wait for user

            Console.ReadKey();
        }
    }
}
