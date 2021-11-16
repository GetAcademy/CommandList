using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandList
{
    class DeleteCommand : Command
    {
        public DeleteCommand(List<string> list)
        :base(list, "Slett", '-')
        {
        }

        public override void Run()
        {
            Console.Write("Hvilken posisjon vil du slette? ");
            var index = Convert.ToInt32(Console.ReadLine()) - 1;
            List.RemoveAt(index);
        }
    }
}
