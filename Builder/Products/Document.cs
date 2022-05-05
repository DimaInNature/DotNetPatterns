namespace Builder.Products;

/// <summary>
/// The Product is a <see langword="class"/> and we want to create this product object using the builder design pattern.
/// <para> This <see langword="class"/> defines different parts that will make the product.</para>
/// </summary>
internal class Document
{
    public string Header { get; set; } = string.Empty;

    public string Body { get; set; } = string.Empty;

    public override string ToString() => $"{Header} {Body}";
}