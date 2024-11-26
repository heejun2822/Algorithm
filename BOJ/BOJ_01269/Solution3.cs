namespace Algorithm.BOJ.BOJ_01269
{
    public class Solution3
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01269/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] counts = Console.ReadLine()!.Split();
            HashSet<int> A = new(Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse));
            HashSet<int> B = new(Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse));
            int cnt = A.Count + B.Count;
            foreach (int i in A) if (B.Contains(i)) cnt -= 2;
            Console.WriteLine(cnt);
        }
    }
}
