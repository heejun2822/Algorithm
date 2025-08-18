namespace Algorithm.BOJ.BOJ_26150
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_26150/input1.txt",
            "BOJ/BOJ_26150/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            (int idx, char c)[] str = new (int, char)[N];

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                string S = input[0];
                int I = int.Parse(input[1]);
                int D = int.Parse(input[2]);

                str[i] = (I, char.ToUpper(S[D - 1]));
            }

            Array.Sort(str);

            System.Text.StringBuilder output = new();

            for (int i = 0; i < N; i++)
                output.Append(str[i].c);

            Console.WriteLine(output);
        }
    }
}
