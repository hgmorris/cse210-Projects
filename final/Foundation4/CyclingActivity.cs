using System;
using System.Collections.Generic;

class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (double)minutes / 60;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}
