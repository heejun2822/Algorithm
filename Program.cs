using Algorithm.BOJ.BOJ_08016;

namespace Algorithm
{
    public class Program
    {
        public static StreamReader InputReader { get; private set; } = new(new BufferedStream(Console.OpenStandardInput()));

        public static void Main(string[] args)
        {
            new Solution().Solve(args);
        }

        public static void SetReader(string path)
        {
            /* Console.ReadLine() 사용할 경우 */
            Console.SetIn(new StringReader(File.ReadAllText(path)));

            /* StreamReader.ReadLine() 사용할 경우 */
            InputReader = new(path);
        }
    }
}
