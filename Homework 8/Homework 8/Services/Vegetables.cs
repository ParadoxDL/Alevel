namespace Services;

class Vegetables
{
    public string Name { get; set; }
    public double Calories { get; set; }

    public Vegetables(string name, double calories)
    {
        Name = name;
        Calories = calories;
    }
}
