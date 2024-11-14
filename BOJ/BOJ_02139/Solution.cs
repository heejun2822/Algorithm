namespace Algorithm.BOJ.BOJ_02139
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02139/input.txt",
        ];

        public static void Run(string[] args)
        {
            StringBuilder answer = new();
            while (true)
            {
                string[] date = Console.ReadLine()!.Split();
                if (date[0] == "0") break;
                int d = int.Parse(date[0]);
                int m = int.Parse(date[1]);
                int y = int.Parse(date[2]);
                int cnt = d;
                for (int i = 1; i < m; i++)
                {
                    cnt += i switch
                    {
                        2 => ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0) ? 29 : 28,
                        4 or 6 or 9 or 11 => 30,
                        _ => 31,
                    };
                }
                answer.AppendLine(cnt.ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
