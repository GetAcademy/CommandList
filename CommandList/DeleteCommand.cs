using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandList
{
    class DeleteCommand : ICommand
    {
        private readonly List<string> _list;
        public string Description { get; private set; }
        public char Key { get; private set; }

        public DeleteCommand(List<string> list)
        {
            _list = list;
            Description = "Slett";
            Key = '-';
        }

        public void Run()
        {
            Console.Write("Hvilken posisjon vil du slette? ");
            var index = Convert.ToInt32(Console.ReadLine()) - 1;
            _list.RemoveAt(index);
        }
    }
}
