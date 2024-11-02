namespace Algorithm.BOJ.BOJ_001330
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_001330/input1.txt",
            "BOJ/BOJ_001330/input2.txt",
            "BOJ/BOJ_001330/input3.txt",
        ];

        public override void Run()
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
