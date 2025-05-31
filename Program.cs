using Algorithm.BOJ.BOJ_06138;

namespace Algorithm
{
    public class Program
    {
        public static StreamReader InputReader { get; private set; } = new(new BufferedStream(Console.OpenStandardInput()));

        public static void Main(string[] args)
        {
            foreach (string inputPath in Solution2.InputPaths)
            {
                /* Console.ReadLine() 사용할 경우 */
                Console.SetIn(new StringReader(File.ReadAllText(inputPath)));

                /* StreamReader.ReadLine() 사용할 경우 */
                InputReader = new(inputPath);

                Solution2.Run(args);
            }
        }
    }
}
