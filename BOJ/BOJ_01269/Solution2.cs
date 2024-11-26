namespace Algorithm.BOJ.BOJ_01269
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01269/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] counts = Console.ReadLine()!.Split();
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int[] B = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            Console.WriteLine(A.Except(B).Count() + B.Except(A).Count());
        }
    }
}
