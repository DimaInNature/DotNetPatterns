// How use it?

//Create concrete builders
DocumentBuilder htmlDocument = new HTMLDocument(),
    wordDocument = new WordDocument();

//Make objects
Document htmlDoc = DocumentDirector.Build(builder: htmlDocument),
    wordDoc = DocumentDirector.Build(builder: wordDocument);

//Display
Console.WriteLine(value: $"{htmlDoc} \n{wordDoc}");

Console.ReadKey();