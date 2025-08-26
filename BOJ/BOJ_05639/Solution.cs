namespace Algorithm.BOJ.BOJ_05639
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05639/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int nodeKey = int.Parse(sr.ReadLine()!);

            TraversePostorder(ref nodeKey, 1_000_000);

            sr.Close();
            sw.Close();

            void TraversePostorder(ref int currentNodeKey, int limit)
            {
                int rootNodeKey = currentNodeKey;

                string input = sr.ReadLine()!;
                currentNodeKey = input != null ? int.Parse(input) : 0;

                if (currentNodeKey != 0 && currentNodeKey < rootNodeKey)
                    TraversePostorder(ref currentNodeKey, rootNodeKey);
                if (currentNodeKey != 0 && currentNodeKey < limit)
                    TraversePostorder(ref currentNodeKey, limit);

                sw.WriteLine(rootNodeKey);
            }
        }
    }
}
