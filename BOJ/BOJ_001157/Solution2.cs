namespace Algorithm.BOJ.BOJ_001157
{
    public class Solution2 : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_001157/input1.txt",
            "BOJ/BOJ_001157/input2.txt",
            "BOJ/BOJ_001157/input3.txt",
            "BOJ/BOJ_001157/input4.txt",
        ];

        public override void Run()
        {
            string word = Console.ReadLine()!.ToUpper();
            int[] counts = new int[26];
            foreach (char c in word) counts[c - 'A']++;
            char answer = '?';
            int max = 0;
            for (int i = 0; i < 26; i++)
            {
                if (counts[i] < max) continue;
                answer = counts[i] > max ? (char)(i + 'A') : '?';
                max = counts[i];
            }
            Console.WriteLine(answer);
        }
    }
}
