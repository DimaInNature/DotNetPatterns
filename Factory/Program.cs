//How use it?

//Create objects
ICar familyCar = CarFactory.GetByCarType(type: CarType.Family),
    sportCar = CarFactory.GetByCarType(type: CarType.Sport);

//Display
Console.WriteLine(value: $"{familyCar} \n{sportCar}");

Console.ReadKey();