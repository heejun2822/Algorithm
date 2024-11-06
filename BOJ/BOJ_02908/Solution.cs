namespace Algorithm.BOJ.BOJ_02908
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02908/input1.txt",
            "BOJ/BOJ_02908/input2.txt",
            "BOJ/BOJ_02908/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] numbers = Console.ReadLine()!.Split();
            string answer = "";
            int idx = -1;
            for (int i = 2; i >= 0; i--)
            {
                if (idx == -1)
                {
                    if (numbers[0][i] > numbers[1][i]) idx = 0;
                    else if (numbers[0][i] < numbers[1][i]) idx = 1;
                }
                answer += numbers[idx == -1 ? 0 : idx][i];
            }
            Console.WriteLine(answer);
        }
    }
}
