namespace Algorithm.BOJ.BOJ_15873
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15873/input1.txt",
            "BOJ/BOJ_15873/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string numbers = Console.ReadLine()!;
            int answer = 0;
            switch (numbers.Length)
            {
                case 2:
                    answer = numbers[0] - '0' + numbers[1] - '0';
                    break;
                case 3:
                    if (numbers[1] == '0') answer = 10 + numbers[2] - '0';
                    else answer = 10 + numbers[0] - '0';
                    break;
                case 4:
                    answer = 20;
                    break;
                default:
                    break;
            }
            Console.WriteLine(answer);
        }
    }
}
