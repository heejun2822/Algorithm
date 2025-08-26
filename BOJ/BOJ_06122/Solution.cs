namespace Algorithm.BOJ.BOJ_06122
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06122/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] numbers = Console.ReadLine()!.Split();
            int N = int.Parse(numbers[0]);
            int Nlines = int.Parse(numbers[1]);

            int[] times = new int[N + 1];
            for (int _ = 0; _ < Nlines; _++)
            {
                string[] entry = Console.ReadLine()!.Split();
                int C = int.Parse(entry[0]);
                string keyword = entry[1];
                int HH = int.Parse(entry[2]);
                int MM = int.Parse(entry[3]);

                if (keyword == "START") times[C] -= HH * 60 + MM;
                else if (keyword == "STOP") times[C] += HH * 60 + MM;
            }

            for (int i = 1; i <= N; i++)
                Console.WriteLine($"{times[i] / 60} {times[i] % 60}");
        }
    }
}
