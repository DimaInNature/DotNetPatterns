namespace Factory.Products;

internal sealed class UnknownCar : ICar
{
    public int GetMaxSpeed() => 0;

    public string GetName() => "Unknown";

    public override string ToString() => $"I'm a unknown car.";
}