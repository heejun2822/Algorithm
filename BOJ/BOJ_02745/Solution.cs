namespace Algorithm.BOJ.BOJ_02745
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02745/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            string N = input[0];
            int B = int.Parse(input[1]);
            int dec = 0;
            for (int i = 0; i < N.Length; i++)
            {
                int digit = char.IsDigit(N[i]) ? N[i] - '0' : N[i] - 'A' + 10;
                int place = (int)Math.Pow(B, N.Length - 1 - i);
                dec += digit * place;
            }
            Console.WriteLine(dec);
        }
    }
}
