namespace Factory.Products;

internal class FamilyCar : ICar
{
    public int GetMaxSpeed() => 60;

    public string GetName() => "Family";

    public override string ToString() => $"I'm a family car and my max speed is 60.";
}