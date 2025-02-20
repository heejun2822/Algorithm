namespace Algorithm.BOJ.BOJ_01450
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01450/input1.txt",
            "BOJ/BOJ_01450/input2.txt",
            "BOJ/BOJ_01450/input3.txt",
            "BOJ/BOJ_01450/input4.txt",
            "BOJ/BOJ_01450/input5.txt",
            "BOJ/BOJ_01450/input6.txt",
        ];

        private static int C;
        private static int[] weights = {};

        public static void Run(string[] args)
        {
            string[] nc = Console.ReadLine()!.Split();
            int N = int.Parse(nc[0]);
            C = int.Parse(nc[1]);
            weights = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            // 중간에서 만나기 (Meet In The Middle, MITM)
            int halfN = N / 2;

            int[] weightSums1 = new int[(int)Math.Pow(2, halfN)];
            int size1 = 0;
            SumWeights(0, halfN - 1, 0, weightSums1, ref size1);
            Array.Sort(weightSums1, 0, size1);

            int[] weightSums2 = new int[(int)Math.Pow(2, N - halfN)];
            int size2 = 0;
            SumWeights(halfN, N - 1, 0, weightSums2, ref size2);
            Array.Sort(weightSums2, 0, size2);

            int cnt = 0;
            int idx2 = size2 - 1;
            for (int idx1 = 0; idx1 < size1; idx1++)
            {
                while (idx2 >= 0 && weightSums1[idx1] + weightSums2[idx2] > C) idx2--;
                cnt += idx2 + 1;
            }

            Console.WriteLine(cnt);
        }

        private static void SumWeights(int idx, int lastIdx, int sum, int[] sums, ref int size)
        {
            if (sum > C) return;

            if (idx > lastIdx)
            {
                sums[size++] = sum;
                return;
            }

            SumWeights(idx + 1, lastIdx, sum, sums, ref size);
            SumWeights(idx + 1, lastIdx, sum + weights[idx], sums, ref size);
        }
    }
}
