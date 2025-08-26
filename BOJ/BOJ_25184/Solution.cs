namespace Algorithm.BOJ.BOJ_25184
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25184/input1.txt",
            "BOJ/BOJ_25184/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder sequence = new();

            int half = N / 2;
            if (N % 2 == 1)
            {
                sequence.Append('1').Append(' ');
                for (int i = half + 1; i > 1; i--)
                    sequence.Append(i).Append(' ').Append(i + half).Append(' ');
            }
            else
            {
                for (int i = half; i > 0; i--)
                    sequence.Append(i).Append(' ').Append(i + half).Append(' ');
            }

            Console.WriteLine(sequence);
        }
    }
}
