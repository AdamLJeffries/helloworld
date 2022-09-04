namespace TEST;

internal class Program
{
    static void Main(string[] args)
    {
        bool open = true;

        do
        {
            Console.WriteLine("Hello, World!");
            string input = Console.ReadLine().ToLower();

            if (input == "exit" )
            {
                open = false;
            };

        } while (open);
    }
}