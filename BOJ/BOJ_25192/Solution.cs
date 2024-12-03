namespace Algorithm.BOJ.BOJ_25192
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25192/input1.txt",
            "BOJ/BOJ_25192/input2.txt",
            "BOJ/BOJ_25192/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            HashSet<string> nicknames = new();

            int cnt = 0;
            for (int _ = 0; _ < N; _++)
            {
                string str = Console.ReadLine()!;
                if (str == "ENTER")
                {
                    cnt += nicknames.Count;
                    nicknames.Clear();
                }
                else nicknames.Add(str);
            }
            cnt += nicknames.Count;

            Console.WriteLine(cnt);
        }
    }
}
