using System;
using System.Collections.Generic;

namespace CommandList
{
    class AddCommand : ICommand
    {
        private readonly List<string> _list;
        public string Description { get; private set; }
        public char Key { get; private set; }

        public AddCommand(List<string> list)
        {
            _list = list;
            Description = "Legg til";
            Key = '+';
        }

        public void Run()
        {
            Console.Write("Hva vil du legge til? ");
            var txt = Console.ReadLine();
            Console.Write("I hvilken posisjon vil du legge det? ");
            var index = Convert.ToInt32(Console.ReadLine()) - 1;
            _list.Insert(index, txt);
        }
    }
}
