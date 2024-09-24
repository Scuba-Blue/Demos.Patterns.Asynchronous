using Demos.Patterns.Asynchronous.Demos.Contracts;

namespace Demos.Patterns.Asynchronous.Demos.Links;

public class UsefulLinksDemo9999
: ISyncDemo
{
    public string Description => throw new NotImplementedException();

    public string Summary => throw new NotImplementedException();

    public short Ordinal => 9999;

    public void RunDemoSync()
    {
        Console.WriteLine("https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/#final-version");
        Console.WriteLine("https://blog.stephencleary.com/2012/02/async-and-await.html");
        Console.WriteLine("https://josipmisko.com/posts/c-sharp-async-vs-sync");
    }
}
