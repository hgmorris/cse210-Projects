using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public abstract class Goal
{
    public string name;
    public int points;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public abstract bool IsCompleted();
    public abstract void RecordEvent();
    public abstract string GetStatusString();
}