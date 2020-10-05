public class Mission
{
    private string name;
    private string description;
    private double distance;
    private int income;
    
    public Mission(string n, string des, double dis, int i)
    {
        this.name = n;
        this.description = des;
        this.distance = dis;
        this.income = i;
    }

    public string GetName()
    {
        return this.name;
    }

    public string GetDescription()
    {
        return this.description;
    }

    public double GetDistance()
    {
        return this.distance;
    }

    public int GetIncome()
    {
        return this.income;
    }
}
