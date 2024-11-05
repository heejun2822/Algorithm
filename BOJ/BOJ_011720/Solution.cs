namespace Algorithm.BOJ.BOJ_011720
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_011720/input1.txt",
            "BOJ/BOJ_011720/input2.txt",
            "BOJ/BOJ_011720/input3.txt",
            "BOJ/BOJ_011720/input4.txt",
        ];

        public override void Run()
        {
            int N = int.Parse(Console.ReadLine()!);
            string numbers = Console.ReadLine()!;
            int sum = numbers.Select(n => (int)Char.GetNumericValue(n)).Sum();
            Console.WriteLine(sum);
        }
    }
}
