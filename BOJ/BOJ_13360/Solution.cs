namespace Algorithm.BOJ.BOJ_13360
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_13360/input1.txt",
            "BOJ/BOJ_13360/input2.txt",
            "BOJ/BOJ_13360/input3.txt",
            "BOJ/BOJ_13360/input4.txt",
            "BOJ/BOJ_13360/input5.txt",
            "BOJ/BOJ_13360/input6.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            bool isPlaying = true;
            int rank = 25;
            int maxStars = 2;
            int stars = 0;
            int consecutiveWins = 0;

            while (isPlaying)
            {
                switch (sr.Read())
                {
                    case 'W':
                        stars += (++consecutiveWins >= 3 && rank >= 6) ? 2 : 1;
                        if (stars > maxStars)
                        {
                            stars -= maxStars;
                            maxStars = GetMaxStars(--rank);
                            if (rank == 0) isPlaying = false;
                        }
                        break;
                    case 'L':
                        consecutiveWins = 0;
                        if (rank == 20 && stars == 0) break;
                        if (rank <= 20 && --stars < 0)
                        {
                            maxStars = GetMaxStars(++rank);
                            stars = maxStars - 1;
                        }
                        break;
                    default:
                        isPlaying = false;
                        break;
                }
            }

            sw.WriteLine(rank == 0 ? "Legend" : rank);

            sr.Close();
            sw.Close();

            int GetMaxStars(int rank)
            {
                if (rank > 20) return 2;
                if (rank > 15) return 3;
                if (rank > 10) return 4;
                return 5;
            }
        }
    }
}
