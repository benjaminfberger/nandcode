namespace src
{
    public static class log
    {
        private static Dictionary<int, string> codes = new()
        {
            { 0, "success" },
            { 1, "no arguments given" },
            { 2, "gcc not installed" },
            { 3, "gcc failed to compile" },
            { 101, "not enough inputs" },
            { 102, "code must end with out:" },
            { 103, "source empty" },
            { 201, "out of memory" },
            { 202, "variable undefined" },
            { 401, "source does not end in .nand" },
            { 402, "program contains no inputs" },
            { 403, "program contains no outputs" }
        };
        public static void error(int code)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"error [nc{code:D3}]: {codes[code]}");
            Environment.Exit(code);
        }
        public static void warn(int code)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"warn [nc{code:D3}]: {codes[code]}");
            Console.ResetColor();
        }
        public static void success(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"success [nc000]: {message}");
            Console.ResetColor();
        }
    }
}
