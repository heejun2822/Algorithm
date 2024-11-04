namespace Algorithm.BOJ.BOJ_010952
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010952/input.txt",
        ];

        public override void Run()
        {
            System.Text.StringBuilder answer = new();
            while (true)
            {
                string[] numbers = Console.ReadLine()!.Split();
                int A = int.Parse(numbers[0]);
                int B = int.Parse(numbers[1]);
                if (A == 0 && B == 0) break;
                answer.AppendLine((A + B).ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
