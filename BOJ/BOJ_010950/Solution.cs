namespace Algorithm.BOJ.BOJ_010950
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010950/input.txt",
        ];

        public override void Run()
        {
            int T = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < T; i++)
            {
                string[] numbers = Console.ReadLine()!.Split();
                int A = int.Parse(numbers[0]);
                int B = int.Parse(numbers[1]);
                Console.WriteLine(A + B);
            }
        }
    }
}
