using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithmsAndStructures.Algorithms
{
    public class DigitalRoot
    {
        public static int Run(long n)
        {
            long result = n;
            while (result > 9)
            {
                result = result.ToString().ToCharArray().Select(n => int.Parse(n.ToString())).Sum();
            }
            return (int) result;
        }
    }
}
