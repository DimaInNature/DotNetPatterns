namespace Builder.Directors;

/// <summary>
/// The Director takes those individual processes from the Builder and defines the sequence to build the product.
/// </summary>
internal sealed class DocumentDirector
{
    public static Document Build(DocumentBuilder builder)
    {
        builder.Create(); // Initial

        builder.SetHeader(); // First step

        builder.SetBody(); // Second step

        return builder.Get();
    }
}