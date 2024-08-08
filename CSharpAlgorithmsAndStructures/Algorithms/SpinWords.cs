using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Algorithms
{
    public class SpinWords
  {
    public static string Run(string sentence)
    {
      string pattern = @"\b\w{6,}\b";
      return Regex.Replace(sentence, pattern, match => new string(match.Value.Reverse().ToArray()));
    }
  }
}

