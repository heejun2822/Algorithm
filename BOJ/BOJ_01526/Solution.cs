namespace Algorithm.BOJ.BOJ_01526
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01526/input1.txt",
            "BOJ/BOJ_01526/input2.txt",
            "BOJ/BOJ_01526/input3.txt",
            "BOJ/BOJ_01526/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string N = Console.ReadLine()!;
            char[] gmn = new char[N.Length];
            for (int i = 0; i < N.Length; i++) gmn[i] = N[i];

            int s = 0, e = N.Length - 1;
            for (int i = N.Length - 1; i >= 0; i--)
            {
                if (gmn[i] == '4' || gmn[i] == '7') continue;

                e = i;
                if (gmn[i] > '7') gmn[i] = '7';
                else if (gmn[i] > '4') gmn[i] = '4';
                else if (i > 0) gmn[--e]--;
                else s = 1;
            }

            for (int i = s; i <= e; i++) Console.Write(gmn[i]);
            for (int i = e + 1; i < N.Length; i++) Console.Write("7");
            Console.Write("\n");
        }
    }
}
