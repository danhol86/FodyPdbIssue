using System;
using System.IO;
using System.Reflection;

namespace Shared
{
    public class TestCode
    {
        public static void Test()
        {
            var myassembly = Assembly.GetEntryAssembly().Location;
            var mypdb = myassembly.Replace(".dll", ".pdb");

            var pdbtext = File.ReadAllText(myassembly);

            var containsnewpath = pdbtext.Contains("MyNewPath");

            Console.WriteLine(containsnewpath ? "YAY!" : "BOO!");

            Console.ReadLine();
        }
    }
}
