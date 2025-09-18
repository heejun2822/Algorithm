namespace Algorithm.BOJ.BOJ_02816
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02816/input1.txt",
            "BOJ/BOJ_02816/input2.txt",
            "BOJ/BOJ_02816/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int kbs1Idx = 0, kbs2Idx = 0;

            for (int i = 0; i < N; i++)
            {
                string channel = Console.ReadLine()!;
                if (channel == "KBS1")
                    kbs1Idx = i;
                else if (channel == "KBS2")
                    kbs2Idx = i;
            }

            System.Text.StringBuilder output = new();

            output.Append(new string('1', kbs1Idx));
            output.Append(new string('4', kbs1Idx));
            if (kbs2Idx < kbs1Idx) kbs2Idx++;
            output.Append(new string('1', kbs2Idx));
            output.Append(new string('4', kbs2Idx - 1));

            Console.WriteLine(output);
        }
    }
}
