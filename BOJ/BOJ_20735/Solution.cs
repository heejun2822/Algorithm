namespace Algorithm.BOJ.BOJ_20735
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_20735/input1.txt",
            "BOJ/BOJ_20735/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            int cnt = 0;

            for (int _ = 0; _ < N; _++)
            {
                string colorName = sr.ReadLine()!;

                string target = "";
                int tIdx = 0;

                for (int i = 0; i < colorName.Length; i++)
                {
                    char c = char.ToLower(colorName[i]);

                    if (tIdx > 0 && c == target[tIdx])
                    {
                        if (++tIdx == target.Length)
                            { cnt++; break; }
                        else
                            continue;
                    }

                    if (c == 'p')
                    {
                        target = "pink";
                        tIdx = 1;
                    }
                    else if (c == 'r')
                    {
                        target = "rose";
                        tIdx = 1;
                    }
                    else
                    {
                        target = "";
                        tIdx = 0;
                    }
                }
            }

            sw.WriteLine(cnt > 0 ? cnt : "I must watch Star Wars with my daughter");

            sr.Close();
            sw.Close();
        }
    }
}
