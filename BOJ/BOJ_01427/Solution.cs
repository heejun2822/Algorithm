namespace Algorithm.BOJ.BOJ_01427
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01427/input1.txt",
            "BOJ/BOJ_01427/input2.txt",
            "BOJ/BOJ_01427/input3.txt",
            "BOJ/BOJ_01427/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] counts = new int[10];
            while (N > 0)
            {
                counts[N % 10]++;
                N /= 10;
            }
            string answer = "";
            for (int i = 0; i < 10; i++) answer = new string((char)('0' + i), counts[i]) + answer;
            Console.WriteLine(answer);
        }
    }
}
