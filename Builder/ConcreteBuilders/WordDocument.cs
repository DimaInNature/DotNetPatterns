namespace Builder.ConcreteBuilders;

/// <summary>
/// The ConcreteBuilder <see langword="class"/> implements the Builder <see langword="interface"/>
/// and provides implementation to all the <see langword="abstract"/> methods. 
/// <para> The Concrete Builder is responsible for constructs and assembles the individual
/// parts of the product by implementing the Builder <see langword="interface"/>.</para> 
/// <para>It also defines and tracks the representation it creates.</para> 
/// </summary>
internal sealed class WordDocument : DocumentBuilder
{
    public override void SetBody()
    {
        if (document is null) document = new();

        document.Body = "I'm a Word body.";
    }

    public override void SetHeader()
    {
        if (document is null) document = new();

        document.Header = "I'm a Word header.";
    }
}