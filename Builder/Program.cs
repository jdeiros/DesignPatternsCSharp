using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age","int");
            Console.WriteLine(cb);
        }
    }

    class CodeBuilder
    {
        private readonly string rootName;

        public CodeBuilder(string rootName)
        {
            
        }

        // not fluent
        public void AddField(string childName, string childText)
        {
            
        }

    }
}
