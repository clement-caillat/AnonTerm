namespace Terminal
{
    public static class Terminal
    {
        public static void Start()
        {   
            while(true)
            {
                Console.Write("AnonTerm> ");
                string? command = Console.ReadLine();
                CommandHandler(command);
            }
        }

        private static void CommandHandler(string? command)
        {
            Command console = new Command();
            try
            {
                if (command != null)
                {
                    string[] args = command.Split(' ');
                    console.commands[args[0]](args);
                }
                else {
                    Error<string>("Command not found");
                }
            } catch(Exception)
            {
                Error<string>($"{command}: Command not found");
            }
        }


        #region Logs
        public static void Log<T>(T p)
        {
            if (p != null)
            {
                Console.WriteLine(p.ToString());
            }
            else
            {
                Error<string>("Incorrect type");
            }
        }

        public static void Warn<T>(T p)
        {
            if (p != null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Warning : " + p.ToString());
                Console.ResetColor();
            }
            else
            {
                Error<string>("Incorrect type");
            }
                
        }

        public static void Error<T>(T p)
        {
            if (p != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"AnonTerm: " + p.ToString());
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error : Incorrect type");
                Console.ResetColor();    
            }
            
        }
        #endregion

    }
}