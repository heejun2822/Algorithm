namespace Algorithm.BOJ.BOJ_14709
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14709/input1.txt",
            "BOJ/BOJ_14709/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int cnt = 0;

            for (int _ = 0; _ < N; _++)
            {
                string[] fingers = Console.ReadLine()!.Split();
                int f1 = int.Parse(fingers[0]);
                int f2 = int.Parse(fingers[1]);

                if ((f1 == 1 || f1 == 3 || f1 == 4) && (f2 == 1 || f2 == 3 || f2 == 4))
                {
                    cnt++;
                }
                else
                {
                    cnt = -1;
                    break;
                }
            }

            Console.WriteLine(cnt == 3 ? "Wa-pa-pa-pa-pa-pa-pow!" : "Woof-meow-tweet-squeek");
        }
    }
}
