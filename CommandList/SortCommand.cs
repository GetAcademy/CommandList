using System.Collections.Generic;

namespace CommandList
{
    class SortCommand : ICommand
    {
        private List<string> _list;
        public char Key { get; }
        public string Description { get; }

        public SortCommand(List<string> list)
        {
            _list = list;
            Key = 's';
            Description = "Sorter";
        }

        public void Run()
        {
            _list.Sort();
        }
    }
}
