namespace Algorithm.BOJ.BOJ_011382
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_011382/input.txt",
        ];

        public override void Run()
        {
            string[] numbers = (Console.ReadLine() ?? "").Split();
            long answer = numbers.Aggregate(0L, (acc, cur) => acc + long.Parse(cur));
            Console.WriteLine(answer);
        }
    }
}
