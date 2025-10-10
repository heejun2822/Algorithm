namespace Algorithm.BOJ.BOJ_10774
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10774/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            Dictionary<char, int> sizeMap = new() { { 'S', 1 }, { 'M', 2 }, { 'L', 3 } };

            int J = int.Parse(sr.ReadLine()!);
            int A = int.Parse(sr.ReadLine()!);

            int[] jerseySizes = new int[J + 1];
            for (int i = 1; i <= J; i++)
                jerseySizes[i] = sizeMap[char.Parse(sr.ReadLine()!)];

            int cnt = 0;

            for (int _ = 0; _ < A; _++)
            {
                string[] input = sr.ReadLine()!.Split();
                int size = sizeMap[char.Parse(input[0])];
                int num = int.Parse(input[1]);
                if (jerseySizes[num] >= size)
                {
                    cnt++;
                    jerseySizes[num] = 0;
                }
            }

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();
        }
    }
}
