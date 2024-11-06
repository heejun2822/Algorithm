namespace Algorithm.BOJ.BOJ_002444
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_002444/input.txt",
        ];

        public override void Run()
        {
            int N = int.Parse(Console.ReadLine()!);
            System.Text.StringBuilder stars = new();
            for (int i = 0; i < 2 * N - 1; i++)
            {
                int b = Math.Abs(i - (N - 1));
                int s = 2 * (N - b) - 1;
                stars.AppendLine(new string(' ', b) + new string('*', s));
            }
            Console.WriteLine(stars);
        }
    }
}
