using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Command pattern
             * Interface
             */

            var list = new List<string>();
            list.Add("en");
            list.Add("to");
            list.Add("tre");

            var commands = new ICommand[]
            {
                new AddCommand(list), 
                new DeleteCommand(list),
                new SortCommand(list),
            };

            while (true)
            {
                ShowList(list);
                ShowMenu(commands);

                Console.Write("Hva vil du gjøre? ");
                var commandChar = Console.ReadLine()[0];
                var command = commands.FirstOrDefault(
                    c => c.Key == commandChar);
                if (command != null)
                {
                    command.Run();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Ukjent kommando: {command}");
                    continue;
                }
                Console.Clear();
            }
        }

        private static void ShowMenu(ICommand[] commands)
        {
            Console.WriteLine();
            foreach (var cmd in commands)
            {
                Console.WriteLine($"{cmd.Key} => {cmd.Description}");
            }
        }

        private static void ShowList(List<string> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("(Listen er tom)");
            }
            else
            {
                for (var index = 0; index < list.Count; index++)
                {
                    var txt = list[index];
                    Console.WriteLine($"{index + 1}: {txt}");
                }
            }
        }
    }
}
