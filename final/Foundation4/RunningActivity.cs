using System;
using System.Collections.Generic;

class Running : Activity
{
    private double distance;

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (double)minutes * 60 * 0.62;
    }

    public override double GetPace()
    {
        return (double)minutes / distance;
    }
}