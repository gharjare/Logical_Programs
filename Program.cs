namespace LogicalPrograms
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs");
            int sum = 0;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == num)
            {
                Console.WriteLine("{0} Number is pefect", num);
            }
            else
            {
                Console.WriteLine("{0} Number is not perfect", num);
            }
        }
    }
}
