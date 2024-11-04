namespace Algorithm.BOJ.BOJ_011022
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_011022/input.txt",
        ];

        public override void Run()
        {
            int T = int.Parse(Console.ReadLine()!);
            System.Text.StringBuilder answer = new();
            for (int i = 1; i <= T; i++)
            {
                string[] numbers = Console.ReadLine()!.Split();
                int A = int.Parse(numbers[0]);
                int B = int.Parse(numbers[1]);
                int C = A + B;
                answer.AppendLine($"Case #{i}: {A} + {B} = {C}");
            }
            Console.WriteLine(answer);
        }
    }
}
