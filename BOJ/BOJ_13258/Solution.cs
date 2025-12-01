namespace Algorithm.BOJ.BOJ_13258
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13258/input1.txt",
            "BOJ/BOJ_13258/input2.txt",
            "BOJ/BOJ_13258/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] balances = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int J = int.Parse(Console.ReadLine()!);
            int C = int.Parse(Console.ReadLine()!);

            int A = balances[0];
            int S = balances.Sum();

            double[] probs = new double[C + 1];
            probs[0] = 1;

            for (int w = 0; w < C; w++)
            {
                for (int i = w; i >= 0; i--)
                {
                    double p = probs[i] * (A + i * J) / (S + w * J);
                    probs[i + 1] += p;
                    probs[i] -= p;
                }
            }

            double E = 0;

            for (int i = 0; i <= C; i++)
                E += (A + i * J) * probs[i];

            Console.WriteLine(E);
        }
    }
}
