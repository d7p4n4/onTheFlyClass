using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onTheFlyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var csc = new CSharpCodeProvider();
            var cc = csc.CreateCompiler();
            CompilerParameters cp = new CompilerParameters();

            cp.ReferencedAssemblies.Add("mscorlib.dll");
            cp.ReferencedAssemblies.Add("System.dll");
            StringBuilder sb = new StringBuilder();
            // The string can contain any valid c# code
            sb.Append("namespace Foo{");
            sb.Append("using System;");
            sb.Append("public static class MyClass{");
            sb.Append("}}");
            // "results" will usually contain very detailed error messages
            var results = csc.CompileAssemblyFromSource(cp, sb.ToString());
            Console.WriteLine(results.ToString());
        }
    }
}
