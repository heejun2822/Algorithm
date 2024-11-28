namespace Algorithm.BOJ.BOJ_11866
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11866/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);

            Person firstPerson = new(1);
            Person person = firstPerson;
            for (int i = 2; i <= N; i++)
            {
                person.SetNextPerson(new(i));
                person = person.NextPerson!;
            }
            person.SetNextPerson(firstPerson);

            int[] orders = new int[N];
            for (int i = 0; i < N; i++)
            {
                for (int _ = 0; _ < K - 1; _++) person = person.NextPerson!;
                orders[i] = person.NextPerson!;
                person.SetNextPerson(person.NextPerson!.NextPerson!);
            }

            Console.WriteLine($"<{string.Join(", ", orders)}>");
        }

        private class Person
        {
            private readonly int m_id;
            public Person? NextPerson { get; private set; }
            public static implicit operator int(Person person) => person.m_id;

            public Person(int id)
            {
                m_id = id;
            }

            public void SetNextPerson(Person person)
            {
                NextPerson = person;
            }
        }
    }
}
