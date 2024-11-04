namespace Algorithm.BOJ.BOJ_015552
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_015552/input.txt",
        ];

        public override void Run()
        {
            int T = int.Parse(Console.ReadLine()!);
            System.Text.StringBuilder answer = new();
            for (int i = 0; i < T; i++)
            {
                string[] numbers = Console.ReadLine()!.Split();
                answer.AppendLine((int.Parse(numbers[0]) + int.Parse(numbers[1])).ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
