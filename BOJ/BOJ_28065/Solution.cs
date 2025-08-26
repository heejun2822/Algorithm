namespace Algorithm.BOJ.BOJ_28065
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28065/input1.txt",
            "BOJ/BOJ_28065/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder SW_Sequence = new();

            int low = 1, high = N, half = N / 2;
            for (int i = 0; i < half; i++)
                SW_Sequence.Append(low++).Append(' ').Append(high--).Append(' ');
            if (N % 2 == 1)
                SW_Sequence.Append(half + 1);

            Console.WriteLine(SW_Sequence);
        }
    }
}
