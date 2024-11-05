namespace Algorithm.BOJ.BOJ_027866
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_027866/input1.txt",
            "BOJ/BOJ_027866/input2.txt",
            "BOJ/BOJ_027866/input3.txt",
        ];

        public override void Run()
        {
            string S = Console.ReadLine()!;
            int i = int.Parse(Console.ReadLine()!);
            Console.WriteLine(S[i - 1]);
        }
    }
}
