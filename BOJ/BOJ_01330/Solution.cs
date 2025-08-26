namespace Algorithm.BOJ.BOJ_01330
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01330/input1.txt",
            "BOJ/BOJ_01330/input2.txt",
            "BOJ/BOJ_01330/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] numbers = Console.ReadLine()!.Split();
            int A = int.Parse(numbers[0]);
            int B = int.Parse(numbers[1]);
            string answer;
            if (A > B) answer = ">";
            else if (A < B) answer = "<";
            else answer = "==";
            Console.WriteLine(answer);
        }
    }
}
