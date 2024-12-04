namespace Algorithm.BOJ.BOJ_24060
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_24060/input1.txt",
            "BOJ/BOJ_24060/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Console.WriteLine(MergeSort(A, 0, N - 1, ref K));
        }

        private static int MergeSort(int[] A, int p, int r, ref int K)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                int res;
                if ((res = MergeSort(A, p, q, ref K)) != -1) return res;
                if ((res = MergeSort(A, q + 1, r, ref K)) != -1) return res;
                return Merge(A, p, q, r, ref K);
            }
            return -1;
        }

        private static int Merge(int[] A, int p, int q, int r, ref int K)
        {
            int[] tmp = new int[r - p + 1];
            int i = p, j = q + 1, t = 0;
            while (i <= q && j <= r)
            {
                if (A[i] <= A[j]) tmp[t++] = A[i++];
                else tmp[t++] = A[j++];
            }
            while (i <= q) tmp[t++] = A[i++];
            while (j <= r) tmp[t++] = A[j++];
            i = p; t = 0;
            while (i <= r)
            {
                if (--K == 0) return tmp[t];
                A[i++] = tmp[t++];
            }
            return -1;
        }
    }
}
