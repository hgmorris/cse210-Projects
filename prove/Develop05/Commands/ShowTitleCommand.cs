using System;
using System.Text;

namespace GoalSetter
{
    public class ShowTitleCommand : Command
    {
        private Terminal _terminal;

        public ShowTitleCommand(Terminal terminal)
        {
            _terminal = terminal;
        }

        public override void Execute()
        {
            try
            {
                string banner = 
                "\n///////////////////////////////////////////////////\n"
                + "// Goal Setter v1.0                              //\n"
                + "// Author: Matt Manley (manleym@byui.edu)        //\n"
                + "///////////////////////////////////////////////////\n"
                + "Enter 'h' for Help\n";
                
                _terminal.WriteLine(banner);
            }
            catch (Exception e)
            {
                _terminal.WriteLine($"Couldn't show the banner. {e.Message}");
            }
        }

        public override string GetName()
        {
            return "";
        }

        public override string GetHelp()
        {
            return "";
        }
    }
}
