namespace Algorithm.BOJ.BOJ_010818
{
    public class Solution2 : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010818/input.txt",
        ];

        public override void Run()
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 1; i < N; i++)
            {
                if (numbers[i] < min) min = numbers[i];
                if (numbers[i] > max) max = numbers[i];
            }
            Console.WriteLine($"{min} {max}");
        }
    }
}
