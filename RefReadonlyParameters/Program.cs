var example = new Example();

var age = 30;

example.Test(ref age);

Console.WriteLine($"The age is: {age}");

class Example()
{

    public void Test(ref readonly int age)
    {
        Console.WriteLine($"The age in method is: {age}");
       // age++;
    }
}