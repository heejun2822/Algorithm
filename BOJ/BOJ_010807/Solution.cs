namespace Algorithm.BOJ.BOJ_010807
{
    public class Solution : SolutionBOJ
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
            int cnt = numbers.Count(n => n == v);
            Console.WriteLine(cnt);
        }
    }
}
