namespace Algorithm.BOJ.BOJ_002562
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_002562/input.txt",
        ];

        public override void Run()
        {
            List<int> numbers = new();
            for (int i = 0; i < 9; i++) numbers.Add(int.Parse(Console.ReadLine()!));
            int max = numbers.Max();
            int index = numbers.IndexOf(max);
            Console.WriteLine(max);
            Console.WriteLine(index + 1);
        }
    }
}
