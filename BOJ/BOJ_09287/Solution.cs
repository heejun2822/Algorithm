namespace Algorithm.BOJ.BOJ_09287
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09287/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int TC = int.Parse(sr.ReadLine()!);
            for (int i = 1; i <= TC; i++)
            {
                int H = int.Parse(sr.ReadLine()!);
                bool isFallen = false;
                for (int _ = 0; _ < H; _++)
                {
                    string row = sr.ReadLine()!;
                    if (isFallen) continue;
                    isFallen = row[1] == '0' && (row[0] == '0' || row[2] == '0');
                }
                sw.Write("Case ");
                sw.Write(i);
                sw.Write(": ");
                sw.Write(isFallen ? "Fallen" : "Standing");
                sw.Write('\n');
            }

            sr.Close();
            sw.Close();
        }
    }
}
