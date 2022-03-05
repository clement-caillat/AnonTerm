namespace App
{
    using Terminal;
    public static class AnonTerm
    {

        private static string _title = "AnonTerm";

        public static void Main()
        {
            Initialize();
            Terminal.Start();
        }

        private static void Initialize()
        {
            Console.Title = _title;
            Console.Clear();
        }
    } 
}