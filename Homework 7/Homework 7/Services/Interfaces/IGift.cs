namespace Services.Interfaces;

internal interface IGift
{
    void GetSweets();
    void SortByWeight();
    double GetTotalWeight();
    Sweets GetSweetByParameter(string parameter);
}
