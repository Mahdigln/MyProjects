using System.Runtime.CompilerServices;

namespace Showcase;

public static class Interception
{
    [InterceptsLocation(
        filePath: "I:\\lab\\experiments\\CSharp12Features\\8.Interceptors\\Showcase\\Program.cs",
        line: 6,
        character: 9)]
    public static void InterceptMethod1(
        this Example example)
    {
        Console.WriteLine("Hello from Interceptor");
    }

    [InterceptsLocation(
    @"I:\lab\experiments\CSharp12Features\8.Interceptors\Showcase\Program.cs",
        8,
        9)]
    public static void InterceptMethod2(
    this Example example, string name)
    {
        Console.WriteLine($"Hello from Interceptor, {name}");
    }
}
