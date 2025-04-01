namespace Algorithm.BOJ.BOJ_02942
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02942/input1.txt",
            "BOJ/BOJ_02942/input2.txt",
            "BOJ/BOJ_02942/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] rg = Console.ReadLine()!.Split();
            int R = int.Parse(rg[0]);
            int G = int.Parse(rg[1]);

            int gcd = GCD(R, G);
            int limit = (int)Math.Sqrt(gcd);
            System.Text.StringBuilder answer = new();

            for (int i = 1; i <= limit; i++)
            {
                if (gcd % i > 0) continue;
                answer.Append(i).Append(' ').Append(R / i).Append(' ').Append(G / i).Append('\n');
                int pair = gcd / i;
                if (pair == i) continue;
                answer.Append(pair).Append(' ').Append(R / pair).Append(' ').Append(G / pair).Append('\n');
            }

            Console.Write(answer);

            int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
        }
    }
}
