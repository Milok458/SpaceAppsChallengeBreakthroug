public class Engine
{
    private string name;
    private string description;
    private double thrust;
    private int devCost;
    private int cost;

    public Engine(string n, string d, double t, int dev, int c)
    {
        this.name = n;
        this.description = d;
        this.thrust = t;
        this.devCost = dev;
        this.cost = c;
    }

    public string GetName()
    {
        return this.name;
    }

    public string GetDescription()
    {
        return this.description;
    }

    public double GetThrust()
    {
        return this.thrust;
    }

    public int GetDevelopmentCost()
    {
        return this.devCost;
    }

    public int GetCost()
    {
        return this.cost;
    }
}
