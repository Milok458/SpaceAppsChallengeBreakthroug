public class Project
{
    private string name;
    private string description;
    private int cost;
    private int income;

    public Project(string n, string d, int c, int i)
    {
        this.name = n;
        this.description = d;
        this.cost = c;
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

    public int GetCost()
    {
        return this.cost;
    }

    public int GetIncome()
    {
        return this.income;
    }
}
