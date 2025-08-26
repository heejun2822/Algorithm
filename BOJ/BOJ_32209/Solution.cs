namespace Algorithm.BOJ.BOJ_32209
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32209/input1.txt",
            "BOJ/BOJ_32209/input2.txt",
            "BOJ/BOJ_32209/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int Q = int.Parse(Console.ReadLine()!);
            int cnt = 0;
            string result = "See you next month";
            for (int _ = 0; _ < Q; _++)
            {
                string[] eventInfo = Console.ReadLine()!.Split();
                if (eventInfo[0] == "1") cnt += int.Parse(eventInfo[1]);
                else cnt -= int.Parse(eventInfo[1]);
                if (cnt < 0)
                {
                    result = "Adios";
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
