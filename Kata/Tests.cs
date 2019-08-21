using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void ShouldHaveEqualInEachBuffer()
        {
            var buffer = Experiment.DoSomething();
        }
    }
}
