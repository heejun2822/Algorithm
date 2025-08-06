namespace Algorithm.BOJ.BOJ_31925
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_31925/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            PriorityQueue<string, int> entrants = new(10);

            for (int _ = 0; _ < N; _++)
            {
                string[] input = sr.ReadLine()!.Split();
                string name = input[0];
                bool isInSchool = input[1] == "jaehak";
                bool hadAwarded = input[2] == "winner";
                int shakeRank = int.Parse(input[3]);
                int apcRank = int.Parse(input[4]);

                if (isInSchool && !hadAwarded && (shakeRank == -1 || shakeRank > 3))
                {
                    if (entrants.Count < 10)
                    {
                        entrants.Enqueue(name, -apcRank);
                    }
                    else if (entrants.TryPeek(out string? n, out int p) && apcRank < -p)
                    {
                        entrants.Dequeue();
                        entrants.Enqueue(name, -apcRank);
                    }
                }
            }

            string[] entrantNames = new string[entrants.Count];
            for (int i = 0; i < entrantNames.Length; i++)
                entrantNames[i] = entrants.Dequeue();

            Array.Sort(entrantNames);

            sw.WriteLine(entrantNames.Length);
            foreach (string name in entrantNames)
                sw.WriteLine(name);

            sr.Close();
            sw.Close();
        }
    }
}
