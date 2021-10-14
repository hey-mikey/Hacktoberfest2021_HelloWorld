using System;

public static class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! Today is " + System.DateTime.Now.ToString(System.Globalization.CultureInfo.CurrentCulture));
        Console.Read();
    }
}
