namespace LogicalPrograms
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs");
            int num, rem, reverse = 0;

            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse number " + reverse);
        }
    }
    }
}
