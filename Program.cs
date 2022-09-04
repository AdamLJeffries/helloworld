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
            string[] exitCmds = { "exit", "terminate", "stop", "quit", "end" };

            if (exitCmds.Contains(input))
            {
                open = false;
            };

        } while (open);
    }
}