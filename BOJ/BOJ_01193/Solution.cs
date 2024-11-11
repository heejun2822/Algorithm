namespace Algorithm.BOJ.BOJ_01193
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01193/input1.txt",
            "BOJ/BOJ_01193/input2.txt",
            "BOJ/BOJ_01193/input3.txt",
            "BOJ/BOJ_01193/input4.txt",
            "BOJ/BOJ_01193/input5.txt",
            "BOJ/BOJ_01193/input6.txt",
            "BOJ/BOJ_01193/input7.txt",
            "BOJ/BOJ_01193/input8.txt",
            "BOJ/BOJ_01193/input9.txt",
            "BOJ/BOJ_01193/input10.txt",
        ];

        public static void Run(string[] args)
        {
            int X = int.Parse(Console.ReadLine()!);
            int layer = 0;
            int elements = 0;
            while (elements < X) elements += ++layer;
            int direction = layer % 2;
            int order = X - (elements - layer);
            int numA = order, numB = layer + 1 - order;
            string answer = direction == 1 ? $"{numB}/{numA}" : $"{numA}/{numB}";
            Console.WriteLine(answer);
        }
    }
}
