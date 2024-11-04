namespace Algorithm.BOJ.BOJ_002739
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_002739/input.txt",
        ];

        public override void Run()
        {
            int N = int.Parse(Console.ReadLine()!);
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{N} * {i} = {N * i}");
            }
        }
    }
}
