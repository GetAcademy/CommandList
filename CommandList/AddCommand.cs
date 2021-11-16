using System;
using System.Collections.Generic;

namespace CommandList
{
    class AddCommand : Command
    {
        public AddCommand(List<string> list)
            : base(list, "Legg til", '+')
        {
        }

        public override void Run()
        {
            Console.Write("Hva vil du legge til? ");
            var txt = Console.ReadLine();
            Console.Write("I hvilken posisjon vil du legge det? ");
            var index = Convert.ToInt32(Console.ReadLine()) - 1;
            List.Insert(index, txt);
        }
    }
}
