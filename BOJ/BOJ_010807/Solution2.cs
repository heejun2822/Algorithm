namespace Algorithm.BOJ.BOJ_010807
{
    public class Solution2 : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010807/input1.txt",
            "BOJ/BOJ_010807/input2.txt",
        ];

        public override void Run()
        {
            int N = int.Parse(Console.ReadLine()!);
            string[] numbers = Console.ReadLine()!.Split();
            string v = Console.ReadLine()!;
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                if (numbers[i] == v) cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
