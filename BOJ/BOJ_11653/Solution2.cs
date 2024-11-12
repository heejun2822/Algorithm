namespace Algorithm.BOJ.BOJ_11653
{
    using System.Text;

    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11653/input1.txt",
            "BOJ/BOJ_11653/input2.txt",
            "BOJ/BOJ_11653/input3.txt",
            "BOJ/BOJ_11653/input4.txt",
            "BOJ/BOJ_11653/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            StringBuilder answer = new();
            int prime = 2;
            while (N > 1)
            {
                if (N % prime == 0)
                {
                    answer.AppendLine(prime.ToString());
                    N /= prime;
                }
                else prime++;
            }
            Console.WriteLine(answer);
        }
    }
}
