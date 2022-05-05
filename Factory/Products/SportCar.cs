namespace Factory.Products;

internal class SportCar : ICar
{
    public int GetMaxSpeed() => 150;

    public string GetName() => "Sport";

    public override string ToString() => $"I'm a sport car and my max speed is 150.";
}