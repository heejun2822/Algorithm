namespace Algorithm.BOJ.BOJ_002753

{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_002753/input1.txt",
            "BOJ/BOJ_002753/input2.txt",
        ];

        public override void Run()
        {
            int year = int.Parse(Console.ReadLine()!);
            int answer = 0;
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) answer = 1;
            Console.WriteLine(answer);
        }
    }
}
