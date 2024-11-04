namespace Algorithm.BOJ.BOJ_008393
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_008393/input.txt",
        ];

        public override void Run()
        {
            int n = int.Parse(Console.ReadLine()!);
            int answer = (1 + n) * n / 2;
            Console.WriteLine(answer);
        }
    }
}
