using System.Linq;
using System.Collections.Generic;
namespace Algorithms
{
    public class Tribonacci
    {

        public static double[] Run(double[] signature, int n)
        {
            if (n <= 2) return signature.Take(n).ToArray();

            return RunRecursive(new List<double>(signature), n).ToArray();
        }

        public static List<double> RunRecursive(List<double> signature, int n)
        {
            if (n == 3) return signature;

            signature.Add(signature[^1] + signature[^2] + signature[^3]);
            return RunRecursive(signature, n - 1);
        }

        public static double[] Run2(double[] signature, int n)
        {
            if (n < 3) return signature.Take(n).ToArray();
            int count = 3;
            List<double> triboList = signature.ToList();
            while (count != n)
            {
                triboList.Add(triboList[count - 3] + triboList[count - 2] + triboList[count - 1]);
                count++;
            }
            return triboList.ToArray();
        }
    }
}
