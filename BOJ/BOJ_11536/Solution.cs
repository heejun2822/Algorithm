namespace Algorithm.BOJ.BOJ_11536
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11536/input1.txt",
            "BOJ/BOJ_11536/input2.txt",
            "BOJ/BOJ_11536/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            string prevName = Console.ReadLine()!;
            string nextName = Console.ReadLine()!;
            int order = prevName.CompareTo(nextName);

            for (int _ = 2; _ < N; _++)
            {
                prevName = nextName;
                nextName = Console.ReadLine()!;

                if (order * prevName.CompareTo(nextName) < 0)
                {
                    order = 0;
                    break;
                }
            }

            Console.WriteLine(order > 0 ? "DECREASING" : order < 0 ? "INCREASING" : "NEITHER");
        }
    }
}
