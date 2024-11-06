namespace Algorithm.BOJ.BOJ_010988
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010988/input1.txt",
            "BOJ/BOJ_010988/input2.txt",
        ];

        public override void Run()
        {
            string word = Console.ReadLine()!;
            int answer = 1;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[^(i + 1)])
                {
                    answer = 0;
                    break;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
