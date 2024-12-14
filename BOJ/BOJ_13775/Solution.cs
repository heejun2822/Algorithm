namespace Algorithm.BOJ.BOJ_13775
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_13775/input.txt",
        ];

        public static void Run(string[] args)
        {
            int key = int.Parse(Console.ReadLine()!);
            string cipher = Console.ReadLine()!;

            for (int i = 0; i < cipher.Length; i++)
            {
                if (cipher[i] < 'a' || cipher[i] > 'z') Console.Write(cipher[i]);
                else
                {
                    int c = cipher[i] - key;
                    Console.Write(c >= 'a' ? (char)c : (char)(c + 26));
                    key = key % 25 + 1;
                }
            }
            Console.Write('\n');
        }
    }
}
