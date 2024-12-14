namespace Algorithm.BOJ.BOJ_29790
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_29790/input1.txt",
            "BOJ/BOJ_29790/input2.txt",
            "BOJ/BOJ_29790/input3.txt",
            "BOJ/BOJ_29790/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] info = Console.ReadLine()!.Split();
            int N = int.Parse(info[0]);
            int U = int.Parse(info[1]);
            int L = int.Parse(info[2]);

            if (N < 1000) { Console.WriteLine("Bad"); return; }
            if (U < 8000 && L < 260) { Console.WriteLine("Good"); return; }
            Console.WriteLine("Very Good");
        }
    }
}
