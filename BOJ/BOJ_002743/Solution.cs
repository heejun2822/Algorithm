namespace Algorithm.BOJ.BOJ_002743
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_002743/input.txt",
        ];

        public override void Run()
        {
            string word = Console.ReadLine()!;
            Console.WriteLine(word.Length);
        }
    }
}
