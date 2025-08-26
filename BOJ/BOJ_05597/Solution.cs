namespace Algorithm.BOJ.BOJ_05597
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05597/input1.txt",
            "BOJ/BOJ_05597/input2.txt",
        ];

        public static void Run(string[] args)
        {
            bool[] homeworks = new bool[30];
            for (int i = 0; i < 28; i++)
            {
                int number = int.Parse(Console.ReadLine()!);
                homeworks[number - 1] = true;
            }
            int cnt = 0;
            for (int i = 0; i < homeworks.Length; i++)
            {
                if (homeworks[i] == true) continue;
                Console.WriteLine(i + 1);
                cnt++;
                if (cnt == 2) break;
            }
        }
    }
}
