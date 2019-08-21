using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Experiment
    {
        public static Dictionary<string, List<string>> DoSomething()
        {
            var dics = new Dictionary<string, List<string>>();
            dics.Add("folder1", new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            dics.Add("folder2", new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            dics.Add("folder3", new List<string> { "1", "2", "3" });
            dics.Add("folder4", new List<string> { "1", "2", "3", "4", "5" });


            var mostfiles = dics.OrderByDescending(d => d.Value.Count()).FirstOrDefault().Value.Count();
            var leastfiles = dics.OrderBy(d => d.Value.Count()).FirstOrDefault().Value.Count();
            var median = mostfiles - leastfiles;

            var newBuffer = new Dictionary<string, List<string>>();

            foreach (var d in dics)
            {
                newBuffer.Add(d.Key, d.Value);

                var diff = mostfiles - d.Value.Count();

                var rand = new Random();
                for (var i = 0; i < diff; i++)
                {
                    newBuffer[d.Key].Add(d.Value.ElementAt(rand.Next(d.Value.Count())));
                }
            }

            return newBuffer;
        }
    }
}
