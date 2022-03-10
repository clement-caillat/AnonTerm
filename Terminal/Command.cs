namespace Terminal
{
    using PackageManager;
    public class Command
    {
        public Dictionary<string, Action<string[]>> commands = new Dictionary<string, Action<string[]>>();

        private Dictionary<string, Action> tools = new Dictionary<string, Action>();

        private Lulz pm = new Lulz();

        private void Init()
        {
            
        }
        public Command()
        {
            Init();
            commands["clear"] = Clear;
            commands["exit"] = Exit;
            commands["lulz"] = Lulz;
            // commands["use"] = Use;
        }

        #region Generic
        public void Clear(string[] args)
        {
            Console.Clear();
        }

        public void Exit(string[] args)
        {   
            Environment.Exit(0);
        }

        public void Lulz(string[] args)
        {
            
        }
        #endregion
    }
}