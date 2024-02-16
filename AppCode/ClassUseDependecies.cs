// Class that uses dependencies from other libraries.
namespace AppCode
{
    public class ClassUseDependecies : Custom.Hybrid.CodeTyped
    {
        public string SayHello() {
            var d1 = new DepLibrary1.DepClass();
            return d1.MyProperty;
        }
    }
}

