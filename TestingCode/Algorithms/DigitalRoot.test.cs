using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;

namespace TestingCode.Algorithms
{
    public class StringToCamelTest
    {
        [Fact]
        public void KataTests()
        {
            Assert.Equal("theStealthWarrior", StringToCamel.Run("the_stealth_warrior"));
            Assert.Equal("TheStealthWarrior", StringToCamel.Run("The-Stealth-Warrior"));
        }
    }
}
