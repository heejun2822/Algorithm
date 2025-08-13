namespace Algorithm.BOJ.BOJ_05077
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05077/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            int Li, Ci, Lm, Cm;
            string[] img, map;

            for (int _ = 0; _ < N; _++)
            {
                string[] input = sr.ReadLine()!.Split();
                Li = int.Parse(input[0]);
                Ci = int.Parse(input[1]);

                img = new string[Li];
                for (int i = 0; i < Li; i++)
                    img[i] = sr.ReadLine()!;

                input = sr.ReadLine()!.Split();
                Lm = int.Parse(input[0]);
                Cm = int.Parse(input[1]);

                map = new string[Lm];
                for (int i = 0; i < Lm; i++)
                    map[i] = sr.ReadLine()!;

                bool[,] visited = new bool[Lm, Cm];
                int cnt = 0;

                for (int l = 0; l <= Lm - Li; l++)
                {
                    for (int c = 0; c <= Cm - Ci; c++)
                    {
                        if (visited[l, c]) continue;

                        visited[l, c] = true;

                        if (FindRigImage(l, c))
                        {
                            cnt++;
                            for (int i = 0; i < Li; i++)
                                for (int j = 0; j < Ci; j++)
                                    visited[l + i, c + j] = true;
                        }
                    }
                }

                sw.WriteLine(cnt);
            }

            sr.Close();
            sw.Close();

            bool FindRigImage(int l, int c)
            {
                for (int i = 0; i < Li; i++)
                    for (int j = 0; j < Ci; j++)
                        if (map[l + i][c + j] != img[i][j])
                            return false;
                return true;
            }
        }
    }
}
