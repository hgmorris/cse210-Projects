using System;
using System.Collections.Generic;

namespace GoalSetter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Repository repository = new InMemRepository();
            Terminal terminal = new Terminal();
            
            CommandFactory factory = new CommandFactory(repository, terminal);
            Commands commands = factory.CreateCommands();
            
            commands.Get("").Execute();
            while (true)
            {
                string name = terminal.ReadString("GS> ");
                commands.Get(name).Execute();     
            }
        }
    }
}
