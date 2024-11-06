namespace Algorithm.BOJ.BOJ_27866
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_27866/input1.txt",
            "BOJ/BOJ_27866/input2.txt",
            "BOJ/BOJ_27866/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string S = Console.ReadLine()!;
            int i = int.Parse(Console.ReadLine()!);
            Console.WriteLine(S[i - 1]);
        }
    }
}
