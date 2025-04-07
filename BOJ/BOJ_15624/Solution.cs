namespace Algorithm.BOJ.BOJ_15624
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15624/input1.txt",
            "BOJ/BOJ_15624/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int F0 = 0, F1 = 1;
            for (int _ = 1; _ < n; _++)
                (F0, F1) = (F1, (F0 + F1) % 1_000_000_007);

            Console.WriteLine(n == 0 ? F0 : F1);
        }
    }
}
