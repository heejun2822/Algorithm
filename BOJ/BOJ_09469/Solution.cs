namespace Algorithm.BOJ.BOJ_09469
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09469/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int P = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < P; _++)
            {
                string[] input = sr.ReadLine()!.Split();
                int N = int.Parse(input[0]);
                float D = float.Parse(input[1]);
                float A = float.Parse(input[2]);
                float B = float.Parse(input[3]);
                float F = float.Parse(input[4]);

                sw.WriteLine($"{N} {D / (A + B) * F}");
            }

            sr.Close();
            sw.Close();
        }
    }
}
