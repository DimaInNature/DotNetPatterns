namespace FluentBuilder.Models;

internal class User
{
    public string Login { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public static UserBuilder GetBuilder() => new();

    public override string ToString() => $"{Login} {Password}";
}