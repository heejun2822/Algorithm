namespace Algorithm.BOJ.BOJ_33231
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_33231/input1.txt",
            "BOJ/BOJ_33231/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr), m = ReadInt(sr);
            int[] coatisSquads = new int[n];
            int[] owlsSquads = new int[m];

            int coatisPikemenCnt = 0;
            int owlsPikemenCnt = 0;

            for (int i = n - 1; i >= 0; i--)
                coatisPikemenCnt += coatisSquads[i] = ReadInt(sr);
            for (int i = 0; i < m; i++)
                owlsPikemenCnt += owlsSquads[i] = ReadInt(sr);

            int idxC = 0, idxO = 0;

            while (idxC < n && idxO < m)
            {
                if (coatisSquads[idxC] > owlsSquads[idxO])
                {
                    int w = coatisSquads[idxC], l = owlsSquads[idxO];
                    int x = (l * l + w - 1) / w;
                    coatisSquads[idxC] -= x;
                    coatisPikemenCnt -= x;
                    owlsSquads[idxO] = 0;
                    owlsPikemenCnt -= l;
                }
                else if (coatisSquads[idxC] < owlsSquads[idxO])
                {
                    int w = owlsSquads[idxO], l = coatisSquads[idxC];
                    int x = (l * l + w - 1) / w;
                    owlsSquads[idxO] -= x;
                    owlsPikemenCnt -= x;
                    coatisSquads[idxC] = 0;
                    coatisPikemenCnt -= l;
                }
                else
                {
                    coatisPikemenCnt -= coatisSquads[idxC];
                    coatisSquads[idxC] = 0;
                    owlsPikemenCnt -= owlsSquads[idxO];
                    owlsSquads[idxO] = 0;
                }

                if (coatisSquads[idxC] == 0)
                    idxC++;
                if (owlsSquads[idxO] == 0)
                    idxO++;
            }

            if (idxC == n && idxO == m)
                sw.WriteLine("stalemate");
            else if (idxC == n)
                sw.WriteLine($"owls\n{owlsPikemenCnt}");
            else if (idxO == m)
                sw.WriteLine($"coatis\n{coatisPikemenCnt}");

            sr.Close();
            sw.Close();
        }

        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
