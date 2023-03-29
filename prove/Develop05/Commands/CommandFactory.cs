using System;

namespace GoalSetter
{
    public class CommandFactory
    {
        private Repository _repository;
        private Terminal _terminal;

        public CommandFactory(Repository repository, Terminal terminal)
        {
            _repository = repository;
            _terminal = terminal;
        }

        public Commands CreateCommands()
        {
            Commands commands = new Commands();

            ShowTitleCommand showTitleCommand 
                = new ShowTitleCommand(_terminal);
            commands.Put(showTitleCommand.GetName(), showTitleCommand);

            QuitAppCommand quitAppCommand 
                = new QuitAppCommand(_terminal);
            commands.Put(quitAppCommand.GetName(), quitAppCommand);

            ShowHelpCommand showHelpCommand 
                = new ShowHelpCommand(commands, _terminal);
            commands.Put(showHelpCommand.GetName(), showHelpCommand);

            ShowGoalsCommand showGoalsCommand 
                = new ShowGoalsCommand(_repository, _terminal);
            commands.Put(showGoalsCommand.GetName(), showGoalsCommand);

            AddGoalCommand addGoalCommand 
                = new AddGoalCommand(_repository, _terminal);
            commands.Put(addGoalCommand.GetName(), addGoalCommand);

            return commands;
        }
    }
}