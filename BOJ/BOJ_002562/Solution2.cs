namespace Algorithm.BOJ.BOJ_002562
{
    public class Solution2 : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_002562/input.txt",
        ];

        public override void Run()
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < 9; i++)
            {
                int num = int.Parse(Console.ReadLine()!);
                if (num < max) continue;
                max = num;
                index = i;
            }
            Console.WriteLine(max);
            Console.WriteLine(index + 1);
        }
    }
}
