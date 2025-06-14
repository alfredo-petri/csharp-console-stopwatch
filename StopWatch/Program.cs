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
        static void Menu()
        {

            string data = MenuOptions();

            char type = data[^1];
            string time = data.Substring(0, data.Length - 1);

            Console.WriteLine("");
            Console.WriteLine(time);
            Console.WriteLine(type);
            Console.WriteLine("");
        }

        static void Validation(string data)
        {
            char type = data[^1];
            string timePart = data.Substring(0, data.Length - 1);

            if (string.IsNullOrEmpty(data) || (data != "0" && data.Length < 2))
            {
                Console.WriteLine("erro");
                return;
            }


            if (type != 's' && type != 'm' && type != '0'  )
            {
                Console.WriteLine("erro");
                return;
            }

            
            if (!int.TryParse(timePart, out int time) || time < 0)
            {
                Console.WriteLine("erro");
                return;
            }
        }

        static string InvalidOption()
        {
            Console.WriteLine("");
            Console.WriteLine("Opção inválida, por favor selecione uma opção válida: ");
            Console.WriteLine("");
            string data = MenuOptions();
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