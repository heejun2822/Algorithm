namespace Algorithm.BOJ.BOJ_010809
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010809/input.txt",
        ];

        public override void Run()
        {
            string S = Console.ReadLine()!;
            int[] arr = Enumerable.Repeat(-1, 26).ToArray();
            for (int i = 0; i < S.Length; i++)
            {
                int idx = S[i] - 'a';
                if (arr[idx] == -1) arr[idx] = i;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
