namespace Algorithm.BOJ.BOJ_32969
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_32969/input1.txt",
            "BOJ/BOJ_32969/input2.txt",
            "BOJ/BOJ_32969/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] digitalHumanities = {"social", "history", "language", "literacy"};
            string[] publicBigdata = {"bigdata", "public", "society"};

            string topic = Console.ReadLine()!;
            string track = "digital humanities";
            foreach (string keyword in publicBigdata)
                if (topic.Contains(keyword)) { track = "public bigdata"; break; }
            Console.WriteLine(track);
        }
    }
}
