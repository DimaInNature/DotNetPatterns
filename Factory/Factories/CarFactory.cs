namespace Factory.Factories;

internal sealed class CarFactory
{
    public static ICar GetByCarType(CarType type) =>
        type switch
        {
            CarType.Sport => new SportCar(),
            CarType.Family => new FamilyCar(),
            _ => new UnknownCar(),
        };
}