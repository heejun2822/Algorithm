namespace Algorithm.BOJ.BOJ_11473
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11473/input.txt",
        ];

        public static void Run(string[] args)
        {
            int k = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new();

            char[] queryString = new char[k];

            Array.Fill(queryString, 'a');
            queryString[0] = 'A';
            RecordQueryString();

            for (int i = 1; i < k; i++)
            {
                queryString[i - 1]++;
                queryString[i] = (char)(queryString[i] - 31);
                RecordQueryString();
            }

            Console.Write(output);

            void RecordQueryString()
            {
                foreach (char c in queryString)
                    output.Append(c);
                output.AppendLine();
            }
        }
    }
}
