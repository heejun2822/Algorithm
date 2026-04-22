namespace Algorithm.BOJ.BOJ_05300
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05300/input1.txt",
            "BOJ/BOJ_05300/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new();
            int idx = 1;

            while (idx <= N)
            {
                int cnt = 0;
                while (idx <= N && cnt < 6)
                {
                    output.Append(idx++).Append(' ');
                    cnt++;
                }
                output.Append("Go! ");
            }

            Console.WriteLine(output);
        }
    }
}
