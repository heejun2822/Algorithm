namespace Algorithm.BOJ.BOJ_02870
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02870/input1.txt",
            "BOJ/BOJ_02870/input2.txt",
            "BOJ/BOJ_02870/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            List<string> numbers = new();

            for (int _ = 0; _ < N; _++)
            {
                string str = Console.ReadLine()!;
                int idx = -1;

                while (++idx < str.Length)
                {
                    if (str[idx] < '0' || str[idx] > '9') continue;

                    int s = idx;
                    while (++idx < str.Length)
                    {
                        if (str[idx] < '0' || str[idx] > '9') break;
                        if (str[s] == '0') s = idx;
                    }
                    numbers.Add(str[s..idx]);
                }
            }

            numbers.Sort((a, b) => a.Length != b.Length ? a.Length - b.Length : a.CompareTo(b));
            foreach (string num in numbers) Console.WriteLine(num);
        }
    }
}
