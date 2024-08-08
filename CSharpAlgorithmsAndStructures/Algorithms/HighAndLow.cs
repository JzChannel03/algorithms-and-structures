namespace Algorithms
{
    public class HighAndLow
    {
        public static string Run(string numbers)
        {
            int[] numbersList = numbers.Split(" ").Select(int.Parse).ToArray();
            return numbersList.Max() + " " + numbersList.Min();
        }
    }
}

