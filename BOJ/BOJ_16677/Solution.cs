namespace Algorithm.BOJ.BOJ_16677
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16677/input1.txt",
            "BOJ/BOJ_16677/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string m = Console.ReadLine()!;
            int N = int.Parse(Console.ReadLine()!);

            double maxValue = 0;
            string answer = "No Jam";

            while (N-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                string w = input[0];
                int g = int.Parse(input[1]);

                int idx = 0;
                int cost = 0;

                foreach (char c in w)
                {
                    if (idx < m.Length && c == m[idx])
                        idx++;
                    else
                        cost++;
                }

                if (idx < m.Length) continue;

                double value = (double)g / cost;
                if (value > maxValue)
                {
                    maxValue = value;
                    answer = w;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
