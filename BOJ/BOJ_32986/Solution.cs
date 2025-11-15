namespace Algorithm.BOJ.BOJ_32986
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32986/input1.txt",
            "BOJ/BOJ_32986/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);
            int Z = int.Parse(input[2]);

            long innerX = Math.Max(X - 2, 0);
            long innerY = Math.Max(Y - 2, 0);
            long innerZ = Math.Max(Z - 2, 0);

            long invisibles = innerX * innerY * innerZ;
            long maxSurfaces = 2 * Math.Max(innerX * innerY, Math.Max(innerX * innerZ, innerY * innerZ));

            int cnt = 0;

            while (invisibles > 1)
            {
                invisibles -= maxSurfaces;
                cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}
