namespace Algorithm.BOJ.BOJ_07596
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_07596/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n;
            int idx = 1;
            System.Text.StringBuilder output = new();

            while ((n = int.Parse(sr.ReadLine()!)) != 0)
            {
                string[] tuneNames = new string[n];
                for (int i = 0; i < n; i++)
                    tuneNames[i] = sr.ReadLine()!;

                Array.Sort(tuneNames);

                output.AppendLine(idx++.ToString());
                foreach (string name in tuneNames)
                    output.AppendLine(name);
            }

            sw.Write(output);

            sr.Close();
            sw.Close();
        }
    }
}
