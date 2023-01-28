namespace LogicalPrograms
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs");
            int a = 0, b = 1, c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                a = b;
                b = c;

                Console.WriteLine(c);
            }
        }
    }
}
