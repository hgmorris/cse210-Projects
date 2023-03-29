using System.Collections.Generic;

namespace GoalSetter
{
    public class InMemRepository : Repository
    {
        private List<Goal> _goals = new List<Goal>();

        public override void Add(Goal goal)
        {
            if (!_goals.Contains(goal))
            {
                _goals.Add(goal);
            }
        }

        public override List<Goal> GetAll()
        {
            return _goals;
        }

        public override void Remove(Goal goal)
        {
            if (_goals.Contains(goal))
            {
                _goals.Remove(goal);
            }
        }
    }
}
