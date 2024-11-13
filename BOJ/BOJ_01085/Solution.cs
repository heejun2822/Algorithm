namespace Algorithm.BOJ.BOJ_01085
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01085/input1.txt",
            "BOJ/BOJ_01085/input2.txt",
            "BOJ/BOJ_01085/input3.txt",
            "BOJ/BOJ_01085/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] info = Console.ReadLine()!.Split();
            int x = int.Parse(info[0]);
            int y = int.Parse(info[1]);
            int w = int.Parse(info[2]);
            int h = int.Parse(info[3]);
            Console.WriteLine(Math.Min(Math.Min(x, w - x), Math.Min(y, h - y)));
        }
    }
}
