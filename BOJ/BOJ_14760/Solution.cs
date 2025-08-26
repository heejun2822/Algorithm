namespace Algorithm.BOJ.BOJ_14760
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14760/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int n = int.Parse(sr.ReadLine()!);

                if (n == 0) break;

                bool[,] grid = new bool[n, n];

                for (int i = 0; i < n; i++)
                {
                    string row = sr.ReadLine()!;
                    for (int j = 0; j < n; j++) grid[i, j] = row[j] == 'X';
                }

                System.Text.StringBuilder rowNums = new();
                System.Text.StringBuilder colNums = new();

                for (int i = 0; i < n; i++)
                {
                    bool rEmpty = true, cEmpty = true;
                    int rNum = 0, cNum = 0;

                    for (int j = 0; j < n; j++)
                    {
                        if (grid[i, j])
                        {
                            rNum++;
                            rEmpty = false;
                        }
                        else if (rNum > 0)
                        {
                            rowNums.Append(rNum).Append(' ');
                            rNum = 0;
                        }

                        if (grid[j, i])
                        {
                            cNum++;
                            cEmpty = false;
                        }
                        else if (cNum > 0)
                        {
                            colNums.Append(cNum).Append(' ');
                            cNum = 0;
                        }
                    }

                    if (rEmpty) rowNums.Append('0');
                    else if (rNum > 0) rowNums.Append(rNum);
                    rowNums.AppendLine();

                    if (cEmpty) colNums.Append('0');
                    else if (cNum > 0) colNums.Append(cNum);
                    colNums.AppendLine();
                }

                sw.Write(rowNums);
                sw.Write(colNums);
            }

            sr.Close();
            sw.Close();
        }
    }
}
