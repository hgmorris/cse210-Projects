using System;
using System.Collections.Generic;

namespace GoalSetter
{
    public class Commands
    {
        private Dictionary<String, Command> _map 
            = new Dictionary<String, Command>();

        public Commands() {}

        public List<Command> AsList()
        {
            List<Command> commands = new List<Command>();
            commands.AddRange(_map.Values);
            return commands;
        }

        public Command Get(string name)
        {
            Command result = null;
            if (_map.ContainsKey(name))
            {
                result = _map[name];
            }
            return result;
        }

        public void Put(string name, Command command)
        {
            if (!_map.ContainsKey(name))
            {
                _map[name] = command;
            }
        }

    }
}
