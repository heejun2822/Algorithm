namespace Algorithm.BOJ.BOJ_02331
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02331/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] ap = Console.ReadLine()!.Split();
            int A = int.Parse(ap[0]);
            int P = int.Parse(ap[1]);

            List<int> sequence = new() { A };
            int cnt = -1;
            
            while (cnt == -1)
            {
                int prev = sequence[^1];
                int num = 0;

                while (prev > 0)
                {
                    num += (int)Math.Pow(prev % 10, P);
                    prev /= 10;
                }

                cnt = sequence.IndexOf(num);
                sequence.Add(num);
            }

            Console.WriteLine(cnt);
        }
    }
}
