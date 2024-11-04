namespace Algorithm.BOJ.BOJ_002439
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_002439/input.txt",
        ];

        public override void Run()
        {
            int N = int.Parse(Console.ReadLine()!);
            System.Text.StringBuilder stars = new();
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < N - i; j++) stars.Append(' ');
                for (int j = 0; j < i; j++) stars.Append('*');
                stars.Append('\n');
            }
            Console.WriteLine(stars);
        }
    }
}
