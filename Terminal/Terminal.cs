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
            if (command == "clear") 
            {
                Clear();
            }else if(command == "exit")
            {
                Exit();
            }
            else
            {
                Error<string>("This command is not recognized");
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
                Console.WriteLine($"Error : " + p.ToString());
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

        #region Basic commands
        public static void Clear()
        {
            Console.Clear();
            Start();
        }

        public static void Exit()
        {
            Log<string>("Goodbye Anonymous :)");
            Thread.Sleep(500);
            Environment.Exit(0);
        }

        #endregion
    }
}