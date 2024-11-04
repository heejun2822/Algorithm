namespace Algorithm.BOJ.BOJ_003052
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_003052/input1.txt",
            "BOJ/BOJ_003052/input2.txt",
            "BOJ/BOJ_003052/input3.txt",
        ];

        public override void Run()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()!);
            }
            int cnt = numbers.Select(n => n % 42).Distinct().Count();
            Console.WriteLine(cnt);
        }
    }
}
