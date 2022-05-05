namespace FluentBuilder.Builders;

internal sealed class UserBuilder
{
    private readonly User _user = new();

    public UserBuilder SetLogin(string login)
    {
        _user.Login = login;

        return this;
    }

    public UserBuilder SetPassword(string password)
    {
        _user.Password = password;

        return this;
    }

    public User Build() => _user;
}