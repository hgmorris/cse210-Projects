using System;
using System.Text;

namespace GoalSetter
{
    public class ShowGoalsCommand : Command
    {
        private Repository _repository;
        private Terminal _terminal;

        public ShowGoalsCommand(Repository repository, Terminal terminal)
        {
            _repository = repository;
            _terminal = terminal;
        }

        public override void Execute()
        {
            try 
            {
                if (_repository.GetAll().Count == 0)
                {
                    _terminal.WriteLine("There are no goals to display.");
                    return;
                }

                _terminal.WriteLine();
                foreach(Goal goal in _repository.GetAll())
                {
                    _terminal.Write(goal.ToString());
                }
            }
            catch (Exception e)
            {
                _terminal.WriteLine($"Couldn't show goals. {e.Message}");
            }
        }

        public override string GetName()
        {
            return "g";
        }

        public override string GetHelp()
        {
            return "g\tDisplays current goal information.\n";
        }
    }
}