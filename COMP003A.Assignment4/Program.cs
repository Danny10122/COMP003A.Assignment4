namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Start/Continue Routine");

            Console.WriteLine("2. View Progess");

            Console.WriteLine("3. Exit");

            Console.Write("\nEnter choice: ");
            int choice = int.Parse(Console.ReadLine());

            while (choice != 3)
            {
                Console.WriteLine("Rountine step " + choice + " completed.");
                choice++;

                Console.Write("\nEnter choice: ");
                

            }




        }
    }
}
