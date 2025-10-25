using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello PRAnalyzer!");

        int unusedVariable; // triggers CS0168: variable declared but never used

        Utils utils = new Utils();
        utils.DoSomething();

        Database db = new Database();
        db.GetUser("admin");
    }
}
