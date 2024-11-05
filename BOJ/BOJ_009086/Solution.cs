namespace Algorithm.BOJ.BOJ_009086
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_009086/input.txt",
        ];

        public override void Run()
        {
            int T = int.Parse(Console.ReadLine()!);
            System.Text.StringBuilder answer = new();
            for (int i = 0; i < T; i++)
            {
                string str = Console.ReadLine()!;
                answer.AppendLine($"{str[0]}{str[^1]}");
            }
            Console.WriteLine(answer);
        }
    }
}
