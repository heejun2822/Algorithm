namespace Algorithm.BOJ.BOJ_25045
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25045/input1.txt",
            "BOJ/BOJ_25045/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            int[] A = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
            int[] B = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            Array.Sort(A, (a, b) => b - a);
            Array.Sort(B);

            int idxA = 0, idxB = 0;
            long sat = 0;

            while (idxA < N && idxB < M && A[idxA] > B[idxB])
            {
                sat += A[idxA++] - B[idxB++];
            }

            sw.WriteLine(sat);

            sr.Close();
            sw.Close();
        }
    }
}
