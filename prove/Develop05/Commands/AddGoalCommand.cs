using System;
using System.Text;

namespace GoalSetter
{
    public class AddGoalCommand : Command
    {
        private Repository _repository;
        private Terminal _terminal;

        public AddGoalCommand(Repository repository, Terminal terminal)
        {
            _repository = repository;
            _terminal = terminal;
        }

        public override void Execute()
        {
            try 
            {
                string name = _terminal.ReadString("Name of goal? ");
                string desc = _terminal.ReadString("Description of goal? ");
                int points = _terminal.ReadInt("Points for goal? ");
                
                Goal goal = new SimpleGoal(name, desc, points);

                _repository.Add(goal);
                _terminal.WriteLine("Your goal was added to the list.\n");
            }
            catch (Exception e)
            {
                _terminal.WriteLine($"Couldn't add goal. {e.Message}");
            }
        }

        public override string GetName()
        {
            return "a";
        }

        public override string GetHelp()
        {
            return "a\tAdds a new goal to the list of goals.\n";
        }
    }
}