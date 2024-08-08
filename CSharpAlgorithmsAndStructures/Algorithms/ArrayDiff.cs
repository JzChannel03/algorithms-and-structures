using System.Linq;
using System.Collections.Generic;


namespace Algorithms
{
  public class ArrayDiff
  {
    public static int[] Run(int[] a, int[] b)
    {
      HashSet<int> bSet = new HashSet<int>(b);
      return a.Where(v => !bSet.Contains(v)).ToArray();
    }
  }
}
