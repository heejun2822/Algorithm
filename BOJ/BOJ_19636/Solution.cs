namespace Algorithm.BOJ.BOJ_19636
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_19636/input1.txt",
            "BOJ/BOJ_19636/input2.txt",
            "BOJ/BOJ_19636/input3.txt",
            "BOJ/BOJ_19636/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int W0 = int.Parse(input[0]);
            int I0 = int.Parse(input[1]);
            int T = int.Parse(input[2]);
            input = Console.ReadLine()!.Split();
            int D = int.Parse(input[0]);
            int I = int.Parse(input[1]);
            int A = int.Parse(input[2]);

            int I1 = I0;
            int W1 = W0 + (I - (I1 + A)) * D;

            Console.WriteLine(W1 > 0 ? $"{W1} {I1}" : "Danger Diet");

            int I2 = I0;
            int W2 = W0;

            for (int _ = 0; _ < D; _++)
            {
                int dw = I - (I2 + A);
                W2 += dw;

                if (Math.Abs(dw) > T)
                {
                    int di = dw > 0 ? dw / 2 : (dw - 1) / 2;
                    I2 += di;
                }

                if (W2 <= 0 || I2 <= 0)
                {
                    Console.WriteLine("Danger Diet");
                    return;
                }
            }

            string yoyo = I0 - I2 > 0 ? "YOYO" : "NO";

            Console.WriteLine($"{W2} {I2} {yoyo}");
        }
    }
}
