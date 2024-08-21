namespace BrainedAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows: ");
            string input = Console.ReadLine();

            int n;
            
            if(int.TryParse(input, out n))
            {
                for(int i = 1; i <= n; i++)
                {
                    for(int k  = 1; k <= n-i; k++)
                    {
                        Console.Write(" ");
                    }

                    for(int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input, Please enter a valid number");
            }         

        }
    }
}