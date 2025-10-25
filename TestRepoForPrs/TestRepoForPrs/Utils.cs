public class Utils
{
    // Existing method
    public void DoSomething()
    {
        int x; // unused variable warning
    }

    // Unused private method
    private void UnusedMethod() { } // triggers warning: method never used

    // New method with unused parameters
    public void ProcessData(string input, int count)
    {
        int localVar; // unused variable
        // input and count are not used → triggers CS0168/CS0219
    }

    // Method with potential null reference
    public void PrintMessage(string? message)
    {
        Console.WriteLine(message.Length); // possible null reference warning
    }

    // Method with bad naming (camelCase instead of PascalCase)
    public void badNamingMethod()
    {
        int y; // unused variable
    }

    // Method with empty catch block (code quality warning)
}
