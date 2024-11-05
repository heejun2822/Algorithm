namespace Algorithm.BOJ.BOJ_011654
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_011654/input1.txt",
            "BOJ/BOJ_011654/input2.txt",
            "BOJ/BOJ_011654/input3.txt",
            "BOJ/BOJ_011654/input4.txt",
            "BOJ/BOJ_011654/input5.txt",
            "BOJ/BOJ_011654/input6.txt",
        ];

        public override void Run()
        {
            char chr = char.Parse(Console.ReadLine()!);
            Console.WriteLine((int)chr);
        }
    }
}
