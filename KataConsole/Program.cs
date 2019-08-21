using Kata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffer = Experiment.DoSomething();

            foreach(var b in buffer)
            {
                Console.WriteLine($"{b.Key}:{string.Join(",", b.Value)}");
            }

            Console.ReadLine();
        }
    }
}
