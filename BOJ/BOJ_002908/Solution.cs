namespace Algorithm.BOJ.BOJ_002908
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_002908/input1.txt",
            "BOJ/BOJ_002908/input2.txt",
            "BOJ/BOJ_002908/input3.txt",
        ];

        public override void Run()
        {
            string[] numbers = Console.ReadLine()!.Split();
            string answer = "";
            int idx = -1;
            for (int i = 2; i >= 0; i--)
            {
                if (idx == -1)
                {
                    if (numbers[0][i] > numbers[1][i]) idx = 0;
                    else if (numbers[0][i] < numbers[1][i]) idx = 1;
                }
                answer += numbers[idx == -1 ? 0 : idx][i];
            }
            Console.WriteLine(answer);
        }
    }
}
