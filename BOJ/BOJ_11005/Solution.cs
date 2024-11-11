namespace Algorithm.BOJ.BOJ_11005
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11005/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int pIdx = 0;
            while (N >= Math.Pow(B, pIdx + 1)) pIdx++;
            int num = N;
            string answer = "";
            for (int i = pIdx; i >= 0; i--)
            {
                int place = (int)Math.Pow(B, i);
                int digit = num / place;
                num %= place;
                answer += digit < 10 ? digit.ToString() : (char)(digit - 10 + 'A');
            }
            Console.WriteLine(answer);
        }
    }
}
