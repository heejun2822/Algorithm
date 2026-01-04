namespace Algorithm.BOJ.BOJ_31837
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31837/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            (int C, int D, int S, int E)[][] lectures = new (int, int, int, int)[N][];

            for (int g = 0; g < N; g++)
            {
                int A = int.Parse(Console.ReadLine()!);
                lectures[g] = new (int, int, int, int)[A];

                for (int l = 0; l < A; l++)
                {
                    string[] info = Console.ReadLine()!.Split(' ', ':');
                    int C = int.Parse(info[0]);
                    int D = int.Parse(info[1]);
                    int S = int.Parse(info[2]) * 100 + int.Parse(info[3]);
                    int E = int.Parse(info[4]) * 100 + int.Parse(info[5]);
                    lectures[g][l] = (C, D, S, E);
                }
            }

            int cnt = 0;
            SelectLectures(0, 0, new());

            Console.WriteLine(cnt);

            void SelectLectures(int group, int totalCredit, List<(int C, int D, int S, int E)> selectedLectures)
            {
                if (totalCredit > 22) return;

                if (group == N)
                {
                    if (totalCredit == 22)
                        cnt++;
                    return;
                }

                foreach (var lecture in lectures[group])
                {
                    bool canSelect = true;

                    foreach (var selected in selectedLectures)
                    {
                        if (lecture.D == selected.D && lecture.S < selected.E && lecture.E > selected.S)
                        {
                            canSelect = false;
                            break;
                        }
                    }

                    if (canSelect)
                    {
                        selectedLectures.Add(lecture);
                        SelectLectures(group + 1, totalCredit + lecture.C, selectedLectures);
                        selectedLectures.Remove(lecture);
                    }
                }

                SelectLectures(group + 1, totalCredit, selectedLectures);
            }
        }
    }
}
