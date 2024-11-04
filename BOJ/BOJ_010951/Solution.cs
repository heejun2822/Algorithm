namespace Algorithm.BOJ.BOJ_010951
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010951/input.txt",
        ];

        public override void Run()
        {
            System.Text.StringBuilder answer = new();
            while (true)
            {
                string? input = Console.ReadLine();
                if (input == null) break;
                string[] numbers = input.Split();
                int A = int.Parse(numbers[0]);
                int B = int.Parse(numbers[1]);
                answer.AppendLine((A + B).ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
