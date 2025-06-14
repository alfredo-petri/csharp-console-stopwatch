namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuOptions();
        }
        static string MenuOptions()
        {
            Console.WriteLine("s = segundos => 10s = 10 segundos");
            Console.WriteLine("m = minutos => 10m = 10 minutos");
            Console.WriteLine("0 = Sair da aplicação");
            Console.WriteLine("Quanto tempo deseja contar?");
            string data = Console.ReadLine().ToLower().Replace(" ", "");

            return data;
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