namespace Algorithm.BOJ.BOJ_018108
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_018108/input.txt",
        ];

        public override void Run()
        {
            string year = Console.ReadLine() ?? "";
            Console.WriteLine(int.Parse(year) - 543);
        }
    }
}
