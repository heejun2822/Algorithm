namespace Algorithm.BOJ.BOJ_30306
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30306/input1.txt",
            "BOJ/BOJ_30306/input2.txt",
            "BOJ/BOJ_30306/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int n = ReadInt();
            int[] dice1 = new int[n];
            for (int i = 0; i < n; i++) dice1[i] = ReadInt();
            int[] dice2 = new int[n];
            for (int i = 0; i < n; i++) dice2[i] = ReadInt();

            Array.Sort(dice1);
            Array.Sort(dice2);

            int diff = 0;
            int idx1 = 0, idx2 = 0;

            while (idx1 < n)
            {
                int cnt = 1;
                while (idx1 < n - 1 && dice1[idx1 + 1] == dice1[idx1]) { idx1++; cnt++; }

                while (idx2 < n && dice1[idx1] > dice2[idx2]) idx2++;

                int tie = 0;
                while (idx2 < n && dice1[idx1] == dice2[idx2]) { idx2++; tie++; }

                diff += (idx2 - tie - (n - idx2)) * cnt;
                idx1++;
            }

            Console.WriteLine(diff > 0 ? "first" : diff < 0 ? "second" : "tie");
        }

        private static int ReadInt()
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = Console.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { Console.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
