using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class StringToCamel
    {
        public static string Run(string str)
        {
            var listWords = str.Split(['_', '-']);
            return listWords[0] + String.Join("", listWords.Skip(1).Select(word => char.ToUpper(word[0]) + word.Substring(1)));
        }
    }
}
