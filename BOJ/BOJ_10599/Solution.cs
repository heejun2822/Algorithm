namespace Algorithm.BOJ.BOJ_10599
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10599/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            while (true)
            {
                string[] inputs = sr.ReadLine()!.Split();
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                int c = int.Parse(inputs[2]);
                int d = int.Parse(inputs[3]);
                if (a == 0 && b == 0 && c == 0 && d == 0) break;
                sw.Write(c - b);
                sw.Write(' ');
                sw.Write(d - a);
                sw.Write('\n');
            }

            sr.Close();
            sw.Close();
        }
    }
}
