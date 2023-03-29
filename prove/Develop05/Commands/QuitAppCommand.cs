using System;
using System.Text;

namespace GoalSetter
{
    public class QuitAppCommand : Command
    {
        private Terminal _terminal;
        
        public QuitAppCommand(Terminal terminal)
        {
            _terminal = terminal;
        }

        public override void Execute()
        {
           _terminal.WriteLine("\nThanks and goodbye!\n");
           Environment.Exit(0);
        }

        public override string GetName()
        {
            return "q";
        }

        public override string GetHelp()
        {
            return "q\tQuits the application.\n";
        }
    }
}
