// using System;
// using System.Text;
// using System.Linq;
// using System.Collections.Generic;
// using System.Reflection;

namespace ThisApp.Code
{
    public class TestImplicitUsings : Custom.Hybrid.CodeTyped
    {
        public static string ForRazor()
        {
            var htmlBuilder = new System.Text.StringBuilder();

            // Adding HTML content

            // 1. based on 'obj/*/*.GlobalUsings.g.cs' for Microsoft.NET.Sdk
            htmlBuilder.AppendLine($"<hr><h2>1. based on 'obj/*/*.GlobalUsings.g.cs' for Microsoft.NET.Sdk</h2>");

            htmlBuilder.AppendLine(CheckType(
                "System is not implicit in C# compiler",
                "DateTime"
            ));

            htmlBuilder.AppendLine(CheckType(
                "System.Collections.Generic is not implicit in C# compiler",
                "List`1[[System.String, mscorlib]]" // this is List<string>
            ));

            htmlBuilder.AppendLine(CheckType(
                "System.IO in not implicit using in C# compiler",
                "File"
            ));

            htmlBuilder.AppendLine(CheckType(
                "System.Linq is not implicit in C# compiler",
                "IQueryable"
            ));

            // htmlBuilder.AppendLine($"<h3>implicit using System.Linq</h3>");

            // // Adding the System.Linq example
            // var names = new System.Collections.Generic.List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
            // htmlBuilder.AppendLine($"<p>Name from list that starts with C: {names.FirstOrDefault()}</p>");


            htmlBuilder.AppendLine(CheckType(
                "System.Net.Http in not referenced in C# compiler",
                "System.Net.Http.HttpClient"
            ));

            htmlBuilder.AppendLine(CheckType(
                "System.Threading is not implicit using in C# compiler",
                "Thread"
            ));

            htmlBuilder.AppendLine(CheckType(
                "System.Threading.Tasks is not implicit using in C# compiler",
                "Task"
            ));


            // 2. based on 'obj/*/*.GlobalUsings.g.cs' for Microsoft.NET.Sdk.Web
            htmlBuilder.AppendLine($"<hr><h2>2. based on 'obj/*/*.GlobalUsings.g.cs' for Microsoft.NET.Sdk.Web</h2>");

            htmlBuilder.AppendLine(CheckType(
                "System.Net.Http.Json is not referenced in C# compiler",
                "System.Net.Http.Json.JsonContent"
            ));

            htmlBuilder.AppendLine(CheckType(
                "Microsoft.AspNetCore.Builder is not referenced in C# compiler",
                "Microsoft.AspNetCore.Builder.ApplicationBuilder"
            ));

            htmlBuilder.AppendLine(CheckType(
                "Microsoft.AspNetCore.Hosting is not referenced in C# compiler",
                "Microsoft.AspNetCore.Hosting.EnvironmentName"
            ));

            htmlBuilder.AppendLine(CheckType(
                "Microsoft.AspNetCore.Http is not referenced in C# compiler",
                "Microsoft.AspNetCore.Http.HttpRequest"
            ));

            htmlBuilder.AppendLine(CheckType(
                "Microsoft.AspNetCore.Routing is not referenced in C# compiler",
                "Microsoft.AspNetCore.Routing.RouteBuilder"
            ));

            htmlBuilder.AppendLine(CheckType(
                "Microsoft.Extensions.Configuration is not referenced in C# compiler",
                "Microsoft.Extensions.Configuration.BinderOptions"
            ));

            htmlBuilder.AppendLine(CheckType(
                "Microsoft.Extensions.DependencyInjection is not referenced in C# compiler",
                "Microsoft.Extensions.DependencyInjection.ActivatorUtilities"
            ));

            htmlBuilder.AppendLine(CheckType(
                "Microsoft.Extensions.Hosting is not referenced in C# compiler",
                "Microsoft.Extensions.Hosting.EnvironmentName"
            ));

            htmlBuilder.AppendLine(CheckType(
                "Microsoft.Extensions.Logging is not referenced in C# compiler",
                "Microsoft.Extensions.Logging.LoggerFactory"
            ));


            // 3. other usings
            htmlBuilder.AppendLine($"<hr><h2>3. other usings</h2>");

            htmlBuilder.AppendLine(CheckType(
                "System.Text is not implicit using in C# compiler",
                "Encoding"
            ));

            htmlBuilder.AppendLine(CheckType(
                "System.Web is not referenced in C# compiler",
                "System.Web.HttpUtility"
            ));

            htmlBuilder.AppendLine(CheckType(
                "System.Web.UI is not referenced in C# compiler",
                "System.Web.UI.Control"
            ));

            htmlBuilder.AppendLine(CheckType(
                "System.Web.UI.WebControls is not referenced in C# compiler",
                "System.Web.UI.WebControls.Button"
            ));

            htmlBuilder.AppendLine(CheckType(
                "System.Web.WebPages is not referenced in C# compiler",
                "System.Web.WebPageRenderingBase"
            ));

            return htmlBuilder.ToString();
        }

        private static string CheckType(string title, string typeName)
        => $"<h3>{title}</h3><p>{CheckType(typeName)}</p>";

        private static string CheckType(string typeName)
        {
            try
            {
                return GetTypeFromName(typeName)?.FullName ?? $"{typeName} is unknown.";
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }

        public static System.Type GetTypeFromName(string typeName)
        {
            // Check in mscorlib
            System.Type type = System.Type.GetType(typeName);
            if (type != null)
                return type;
           
            // // Check in the currently executing assembly
            // type = Type.GetType(typeName, assemblyResolver: asmName => Assembly.GetExecutingAssembly(), typeResolver: null);
            // if (type != null)
            //     return type;

            // // Optionally, check in other loaded assemblies
            // foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            // {
            //     type = asm.GetType(typeName);
            //     if (type != null)
            //         return type;
            // }

            return null; // Type not found
        }
    }
}
