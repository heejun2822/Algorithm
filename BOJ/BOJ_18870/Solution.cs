namespace Algorithm.BOJ.BOJ_18870
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_18870/input1.txt",
            "BOJ/BOJ_18870/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());
            int N = int.Parse(sr.ReadLine()!);
            int[] X = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
            int i = 0;
            (int x, int idx)[] indexedX = Array.ConvertAll(X, x => (x, i++));
            Array.Sort(indexedX);
            i = 0;
            int prevX = indexedX[0].x;
            foreach ((int x, int idx) in indexedX)
            {
                if (x != prevX) i++;
                X[idx] = i;
                prevX = x;
            }
            sw.WriteLine(string.Join(' ', X));
            sr.Close();
            sw.Close();
        }
    }
}
