namespace Algorithm.BOJ.BOJ_03036
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_03036/input1.txt",
            "BOJ/BOJ_03036/input2.txt",
            "BOJ/BOJ_03036/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] radii = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            for (int i = 1; i < N; i++)
            {
                int gcd = radii[0];
                int rem = radii[i];
                while (rem > 0) (gcd, rem) = (rem, gcd % rem);

                Console.WriteLine($"{radii[0] / gcd}/{radii[i] / gcd}");
            }
        }
    }
}
