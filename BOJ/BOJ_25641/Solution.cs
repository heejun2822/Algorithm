namespace Algorithm.BOJ.BOJ_25641
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25641/input1.txt",
            "BOJ/BOJ_25641/input2.txt",
            "BOJ/BOJ_25641/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string stst = Console.ReadLine()!;

            int diff = 0;
            int sIdx = N;

            for (int i = N - 1; i >= 0; i--)
                if ((diff += stst[i] == 's' ? 1 : -1) == 0) sIdx = i;

            Console.WriteLine(stst[sIdx..]);
        }
    }
}
