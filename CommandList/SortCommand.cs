using System.Collections.Generic;

namespace CommandList
{
    class SortCommand : Command
    {
        public SortCommand(List<string> list)
        :base(list, "Sorter", 's')
        {
        }

        public override void Run()
        {
            List.Sort();
        }
    }
}
