using System;
using System.Text;

namespace GoalSetter
{
    public class ShowHelpCommand : Command
    {
        private Commands _commands;
        private Terminal _terminal;
        
        public ShowHelpCommand(Commands commands, Terminal terminal)
        {
            _commands = commands;
            _terminal = terminal;
        }

        public override void Execute()
        {
            try
            {
                _terminal.Write("\n");
                foreach (Command command in _commands.AsList())
                {
                    string help = command.GetHelp();
                    _terminal.Write(help);
                }
                _terminal.Write("\n");
            }
            catch(Exception e)
            {
                _terminal.WriteLine($"Couldn't show help. {e.Message}");
            }
        }

        public override string GetName()
        {
            return "h";
        }

        public override string GetHelp()
        {
            return "h\tDisplays help or specific command information.\n";
        }
    }
}
