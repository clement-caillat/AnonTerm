namespace Terminal
{
    public class Command
    {
        public Dictionary<string, System.Action<string[]>> commands = new Dictionary<string, System.Action<string[]>>();

        public Command()
        {
            commands["clear"] = Clear;
            commands["exit"] = Exit;
            commands["use"] = Use;
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

        public void Use(string[] args)
        {
            Terminal.Log<string>(args[1]);
        }
        #endregion
    }
}