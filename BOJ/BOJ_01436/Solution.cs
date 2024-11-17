namespace Algorithm.BOJ.BOJ_01436
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01436/input1.txt",
            "BOJ/BOJ_01436/input2.txt",
            "BOJ/BOJ_01436/input3.txt",
            "BOJ/BOJ_01436/input4.txt",
            "BOJ/BOJ_01436/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int cnt = 1;
            int num = 666;
            while (cnt < N) if ((++num).ToString().Contains("666")) cnt++;
            Console.WriteLine(num);
        }
    }
}
