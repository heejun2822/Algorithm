namespace Algorithm.BOJ.BOJ_010818
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010818/input.txt",
        ];

        public override void Run()
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            Console.WriteLine($"{numbers.Min()} {numbers.Max()}");
        }
    }
}
