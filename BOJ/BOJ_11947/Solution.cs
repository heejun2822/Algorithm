namespace Algorithm.BOJ.BOJ_11947
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11947/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                string strN = Console.ReadLine()!;
                int N = int.Parse(strN);

                long num = Math.Min(N, 5 * (long)Math.Pow(10, strN.Length - 1));

                Console.WriteLine(num * ((long)Math.Pow(10, strN.Length) - 1 - num));
            }
        }
    }
}
