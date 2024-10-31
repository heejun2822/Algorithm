namespace Algorithm.BOJ.BOJ_010926
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010926/input1.txt",
            "BOJ/BOJ_010926/input2.txt",
        ];

        public override void Run()
        {
            string id = Console.ReadLine() ?? "";
            Console.WriteLine(id + "??!");
        }
    }
}
