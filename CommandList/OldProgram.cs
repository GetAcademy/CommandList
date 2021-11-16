using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandList
{
    class OldProgram
    {
        static void Mainx(string[] args)
        {
            var list = new List<string>();

            while (true)
            {
                if (list.Count == 0)
                {
                    Console.WriteLine("(Listen er tom.)");
                }
                else
                {
                    for (var index = 0; index < list.Count; index++)
                    {
                        var txt = list[index];
                        Console.WriteLine($"{index + 1}: {txt}");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("+ => Legg til");
                Console.WriteLine("- => Slett");

                Console.Write("Hva vil du gjøre? ");
                var command = Console.ReadLine()[0];
                if (command == '+')
                {
                    Console.Write("Hva vil du legge til? ");
                    var txt = Console.ReadLine();
                    Console.Write("I hvilken posisjon vil du legge det? ");
                    var index = Convert.ToInt32(Console.ReadLine()) - 1;
                    list.Insert(index, txt);

                }
                else if (command == '-')
                {
                    Console.Write("Hvilken posisjon vil du slette? ");
                    var index = Convert.ToInt32(Console.ReadLine()) - 1;
                    list.RemoveAt(index);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Ukjent kommando: {command}");
                    return;
                }
                Console.Clear();
            }
        }
    }
}
