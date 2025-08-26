namespace Algorithm.BOJ.BOJ_09449
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09449/input1.txt",
            "BOJ/BOJ_09449/input2.txt",
            "BOJ/BOJ_09449/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int W = int.Parse(input[0]);
            int H = int.Parse(input[1]);
            int w = int.Parse(input[2]);
            int h = int.Parse(input[3]);

            int cntW = (W / w + 1) / 2;
            int cntH = (H / h + 1) / 2;
            Console.WriteLine(cntW * cntH);
        }
    }
}
