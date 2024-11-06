namespace Algorithm.BOJ.BOJ_03052
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_03052/input1.txt",
            "BOJ/BOJ_03052/input2.txt",
            "BOJ/BOJ_03052/input3.txt",
        ];

        public static void Run(string[] args)
        {
            List<int> uniques = new();
            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine()!);
                int remainder = num % 42;
                bool isDuplicated = false;
                for (int j = 0; j < uniques.Count; j++)
                {
                    if (uniques[j] == remainder)
                    {
                        isDuplicated = true;
                        break;
                    }
                }
                if (!isDuplicated) uniques.Add(remainder);
            }
            Console.WriteLine(uniques.Count);
        }
    }
}
