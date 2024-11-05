namespace Algorithm.BOJ.BOJ_001152
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_001152/input1.txt",
            "BOJ/BOJ_001152/input2.txt",
            "BOJ/BOJ_001152/input3.txt",
        ];

        public override void Run()
        {
            string str = Console.ReadLine()!.Trim();
            int cnt = str.Length == 0 ? 0 : 1;
            foreach (char c in str)
            {
                if (c == ' ') cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
