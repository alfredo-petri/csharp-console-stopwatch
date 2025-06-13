namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            int time = 10;
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine("");
                Console.WriteLine(currentTime);
                Console.WriteLine("");
                Thread.Sleep(1000);
            }
        }
    }
}