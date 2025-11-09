namespace Algorithm.BOJ.BOJ_20921
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20921/input1.txt",
            "BOJ/BOJ_20921/input2.txt",
            "BOJ/BOJ_20921/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            System.Text.StringBuilder v = new();

            int num = N;

            while (K > 0 && K >= num - 1)
            {
                v.Append(num).Append(' ');
                K -= num - 1;
                num--;
            }

            for (int i = 1; i < num - K; i++)
                v.Append(i).Append(' ');

            v.Append(num).Append(' ');

            for (int i = num - K; i < num; i++)
                v.Append(i).Append(' ');

            Console.WriteLine(v);
        }
    }
}
