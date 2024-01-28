namespace Services.Interfaces;

internal interface ISalad
{
    void GetVegetables();
    void SortByCalories();
    double GetTotalCalories();
    Vegetables GetVegetablesByParameter(string parameter);
}
