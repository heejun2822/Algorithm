namespace Algorithm.BOJ.BOJ_26069
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_26069/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            HashSet<string> dancings = new(N) {"ChongChong"};
            for (int _ = 0; _ < N; _++)
            {
                string[] people = Console.ReadLine()!.Split();
                string A = people[0];
                string B = people[1];
                if (dancings.Contains(A)) dancings.Add(B);
                else if (dancings.Contains(B)) dancings.Add(A);
            }

            Console.WriteLine(dancings.Count);
        }
    }
}
