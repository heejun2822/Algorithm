namespace Algorithm.BOJ.BOJ_16581
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_16581/input1.txt",
            "BOJ/BOJ_16581/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            bool isTrue = true;

            for (int _ = 0; _ < N; _++)
            {
                string S = Console.ReadLine()!;
                if (S[0] == 'L') isTrue = !isTrue;
            }

            Console.WriteLine(isTrue ? "TRUTH" : "LIE");
        }
    }
}
