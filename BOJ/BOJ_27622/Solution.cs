namespace Algorithm.BOJ.BOJ_27622
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_27622/input1.txt",
            "BOJ/BOJ_27622/input2.txt",
            "BOJ/BOJ_27622/input3.txt",
            "BOJ/BOJ_27622/input4.txt",
            "BOJ/BOJ_27622/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = ReadInt();

            bool[] isLoggedIn = new bool[1001];

            int cnt = 0;

            for (int _ = 0; _ < N; _++)
            {
                int a = ReadInt();

                if (a > 0) isLoggedIn[a] = true;
                else if (isLoggedIn[-a]) isLoggedIn[-a] = false;
                else cnt++;
            }

            Console.WriteLine(cnt);
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
