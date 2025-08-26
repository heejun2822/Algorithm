namespace Algorithm.BOJ.BOJ_02231
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02231/input.txt",
        ];

        public static void Run(string[] args)
        {
            string strN = Console.ReadLine()!;
            int N = int.Parse(strN);
            for (int i = N - (9 * (strN.Length - 1) + strN[0] - '1'); i < N; i++)
            {
                int sum = i;
                foreach (char digit in i.ToString()) sum += digit - '0';
                if (sum == N)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("0");
        }
    }
}
