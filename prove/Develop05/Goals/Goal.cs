namespace GoalSetter
{
    public class Goal
    {
        private string _name = "";
        private string _desc = "";
        private int _points = 0;
        private int _earnedPoints = 0;
        private bool _complete = false;

        public Goal(string name, string desc, int points)
        {
            _name = name;
            _desc = desc;
            _points = points;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDesc()
        {
            return _desc;
        }

        public int GetPoints()
        {
            return _points;
        }

        public int GetEarnedPoints()
        {
            return _earnedPoints;
        }

        public virtual void MarkIncomplete()
        {
            _complete = false;
        }

        public virtual void MarkComplete()
        {
            _complete = true;
        }

        public virtual void AddPoints(int points)
        {
            _earnedPoints += points;
        }

        public bool IsComplete()
        {
            return _complete;
        }

        public override string ToString()
        {
            string s = "";
            s += $"name: {GetName()}\n";
            s += $"desc: {GetDesc()}\n";
            s += $"points: {GetPoints()}\n";
            s += $"earned: {GetEarnedPoints()}\n";
            s += $"complete: {IsComplete()}\n\n";
            return s;
        }
    }
}