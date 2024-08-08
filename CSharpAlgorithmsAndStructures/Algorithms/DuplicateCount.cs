using System.Linq;
using System.Collections.Generic;

namespace Algorithms
{
    public class DuplicateCount
    {
        public static int Run(string str)
        {
            HashSet<char> letterSet = new HashSet<char>();
            HashSet<char> duplicateSet = new HashSet<char>();
            foreach (char letter in str.ToLower())
            {
                if (!letterSet.Add(letter))
                {
                    duplicateSet.Add(letter);
                }
            }
            return duplicateSet.Count;
        }

        public static int Run2(string str)
        {
            return str.ToLower().GroupBy(s => s).Count(s => s.Count() > 1);
        }
    }
}

