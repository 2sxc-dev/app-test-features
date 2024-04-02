public class SharedHelperCode
{
    // This is a shared helper code file, which can be used in multiple projects
    // It's a good place to put code which is used in multiple places, to keep it DRY
    // DRY = Don't Repeat Yourself
    // This is a simple example, but you could also put more complex code here

    // This method is used in both the AppCodeGetCodeController and My2Controller
    public string GetHelloMessage()
    {
        return "Hello from SharedHelperCode.";
    }
}