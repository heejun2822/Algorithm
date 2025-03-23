namespace Algorithm.BOJ.BOJ_25829
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25829/input1.txt",
            "BOJ/BOJ_25829/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int majorityVotes = 0;
            int electoralVotes = 0;

            for (int _ = 0; _ < n; _++)
            {
                string[] voteInfo = Console.ReadLine()!.Split();
                int e = int.Parse(voteInfo[0]);
                int v1 = int.Parse(voteInfo[1]);
                int v2 = int.Parse(voteInfo[2]);

                majorityVotes += v1 - v2;
                electoralVotes += v1 > v2 ? e : -e;
            }

            if (majorityVotes > 0 && electoralVotes > 0) Console.WriteLine("1");
            else if (majorityVotes < 0 && electoralVotes < 0) Console.WriteLine("2");
            else Console.WriteLine("0");
        }
    }
}
