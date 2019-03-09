using System;
using System.Reflection;

namespace AssemblyAttributeTest
{



    [AttributeUsage(AttributeTargets.Assembly)]
    public class BuildMachineNameAttribute : Attribute
    {
        public BuildMachineNameAttribute(string value)
        {
            MachineName = value;
        }

        public string MachineName { get; }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var entryAssembly = Assembly.GetEntryAssembly();
            var property = entryAssembly?
              .GetCustomAttribute<BuildMachineNameAttribute>()?
              .MachineName ?? "";
            Console.WriteLine($"BuildMachineName {property}");
            Console.ReadLine();
        }
    }
}
