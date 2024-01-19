namespace Services;

class Sweets
{
    public string Name { get; set; }
    public double Weight { get; set; }

    public Sweets(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }
}
