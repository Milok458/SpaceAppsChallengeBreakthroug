using System;

public class Ship
{
    private string description;
    private double speed;
    private int weight;
    private Engine engineType;

    public Ship(Engine e, int w, double s)
    {
        this.speed = s;
        this.weight = w;
        this.engineType = e;
        this.description = "Details\n" + "Engine Model: " + engineType.GetName() + "\n"+ "Speed: " + Math.Truncate(speed * 100) / 100 + "kmph\n"
            + "Weight: " + weight + "N\n" + "Crew Capacity: 5 people";
    }

    public void SetEngine(Engine e)
    {
        this.engineType = e;
    }

    public void SetSpeed(double s)
    {
        this.speed = s;
    }

    public void UpdateDescription()
    {
        this.description = "Details\n" + "Engine Model: " + engineType.GetName() + "\n" + "Speed: " + Math.Truncate(speed * 100) / 100 + "kmph\n"
            + "Weight: " + weight + "N\n" + "Crew Capacity: 5 people";
    }
}
