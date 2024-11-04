namespace Algorithm.BOJ.BOJ_003052
{
    public class Solution2 : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_003052/input1.txt",
            "BOJ/BOJ_003052/input2.txt",
            "BOJ/BOJ_003052/input3.txt",
        ];

        public override void Run()
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
