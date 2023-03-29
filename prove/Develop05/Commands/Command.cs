using System;

namespace GoalSetter
{
    public class Command
    {
        public virtual void Execute()
        {
            throw new Exception("Execute not implemented in base class.");
        }

        public virtual string GetName()
        {
            throw new Exception("GetName not implemented in base class.");
        }

        public virtual string GetHelp()
        {
            throw new Exception("GetHelp not implemented in base class.");
        }
    }
}
