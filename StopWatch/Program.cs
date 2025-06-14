namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
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
        
        static void Menu()
        {

            string data = MenuOptions();

            char type = data[^1];
            int time = int.Parse(data.Substring(0, data.Length - 1));

            if (time == 0) {
                Environment.Exit(0);
            }

            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }


            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
            Start(time);
        }

        static void Start(int timeInSeconds)
        {
            int time = timeInSeconds;
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
            Console.Clear();
            Console.WriteLine("StopWatch finalizado!");
            Thread.Sleep(3000);
            Menu();
        }
    }
}