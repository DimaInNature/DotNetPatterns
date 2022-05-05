namespace Builder.Builders;

/// <summary>
/// The Builder is an interface that defines all the steps which are used to make the concrete product.
/// </summary>
internal abstract class DocumentBuilder
{
    protected Document? document;

    public abstract void SetHeader();

    public abstract void SetBody();

    public void Create() => document = new();

    public Document Get() => document ?? new();
}