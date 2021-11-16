using System.Collections.Generic;

namespace CommandList
{
    abstract class Command
    {
        protected List<string> List { get; }
        public string Description { get; }
        public char Key { get; }
        public abstract void Run();

        protected Command(
            List<string> list, 
            string description, 
            char key)
        {
            List = list;
            Description = description;
            Key = key;
        }

    }
}
