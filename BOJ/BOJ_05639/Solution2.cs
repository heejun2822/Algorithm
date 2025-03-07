namespace Algorithm.BOJ.BOJ_05639
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05639/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            const int INF = 1_000_000;

            TraversePostorder(int.Parse(sr.ReadLine()!), INF);

            sr.Close();
            sw.Close();

            int TraversePostorder(int currentNodeKey, int limit)
            {
                string input = sr.ReadLine()!;
                int nextNodeKey = input != null ? int.Parse(input) : INF;

                if (nextNodeKey < currentNodeKey)
                    nextNodeKey = TraversePostorder(nextNodeKey, currentNodeKey);
                if (nextNodeKey < limit)
                    nextNodeKey = TraversePostorder(nextNodeKey, limit);

                sw.WriteLine(currentNodeKey);

                return nextNodeKey;
            }
        }
    }
}
