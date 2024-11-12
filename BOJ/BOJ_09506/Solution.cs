namespace Algorithm.BOJ.BOJ_09506
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09506/input.txt",
        ];

        public static void Run(string[] args)
        {
            StringBuilder answer = new();
            while (true)
            {
                int n = int.Parse(Console.ReadLine()!);
                if (n == -1) break;
                if (IsPerfectNumber(n, out List<int> factors))
                {
                    answer.AppendLine($"{n} = {string.Join(" + ", factors)}");
                }
                else
                {
                    answer.AppendLine($"{n} is NOT perfect.");
                }
            }
            Console.WriteLine(answer);
        }

        private static bool IsPerfectNumber(int n, out List<int> factors)
        {
            factors = new();
            List<int> listA = new() {1}, listB = new();
            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i != 0) continue;
                listA.Add(i);
                sum += i;
                int pair = n / i;
                if (pair != i)
                {
                    listB.Add(pair);
                    sum += pair;
                }
                if (sum > n) return false;
            }
            if (sum != n) return false;
            listB.Reverse();
            listA.AddRange(listB);
            factors = listA;
            return true;
        }
    }
}
