namespace Algorithm.BOJ.BOJ_011718
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_011718/input.txt",
        ];

        public override void Run()
        {
            System.Text.StringBuilder input = new();
            for (int i = 0; i < 100; i++)
            {
                string? line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) break;
                input.AppendLine(line);
            }
            Console.WriteLine(input);
        }
    }
}
