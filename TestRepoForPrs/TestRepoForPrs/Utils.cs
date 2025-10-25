public class Utils
{
    public void DoSomething()
    {
        int x; // unused variable warning
    }

    private void UnusedMethod() { } // triggers warning: method never used
}
