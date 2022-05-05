//How use it?

//Create object
User user = User.GetBuilder()
    .SetLogin(login: "MyLogin")
    .SetPassword(password: "MyPassword")
    .Build();

//Display
Console.WriteLine(value: user);

Console.ReadKey();