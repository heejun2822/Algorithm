namespace Algorithm.BOJ.BOJ_04589
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_04589/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Gnomes:");

            for (int _ = 0; _ < N; _++)
            {
                int[] beards = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                if ((beards[0] > beards[1] && beards[1] > beards[2]) || (beards[0] < beards[1] && beards[1] < beards[2]))
                    Console.WriteLine("Ordered");
                else
                    Console.WriteLine("Unordered");
            }
        }
    }
}
