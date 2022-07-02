using System;
using System.Diagnostics;

namespace ConsoleExtensions
{
    /// <summary>
    /// An extension of the default console class providing additional features.
    /// </summary>
    public static class ConsoleExtensions
    {
        #region Properties

        private static ConsoleColor cachedConsoleTextColour = Console.ForegroundColor;
        private static ConsoleColor cachedConsoleBackgroundColour = Console.BackgroundColor;

        #endregion

        #region Console Colour Methods

        /// <summary>
        /// Sets the colour of the console's text (or foreground).
        /// </summary>
        public static void SetConsoleTextColour(ConsoleColor colour)
        {
            Console.ForegroundColor = cachedConsoleTextColour = colour;
        }

        /// <summary>
        /// Sets the colour of the console's background.
        /// </summary>
        public static void SetConsoleBackgroundColour(ConsoleColor colour)
        {
            Console.BackgroundColor = cachedConsoleBackgroundColour = colour;
        }

        #endregion

        #region Console Logging Methods

        /// <summary>
        /// Writes text to the console prefixed with a green 'INPUT' and returns true if 'y' is entered, and false if 'n' is entered.
        /// </summary>
        public static bool LogInput(string content)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("INPUT");
            Console.ForegroundColor = cachedConsoleTextColour;
            Console.Write("] " + content);

            string input = Console.ReadLine().ToLower();
            if (input == "y") return true;
            if (input == "n") return false;
            throw new Exception($"'{input}' is not a valid input response.");
        }

        /// <summary>
        /// Writes text to the console prefixed with a cyan 'INFO'.
        /// </summary>
        public static void LogInfo(string content)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("INFO");
            Console.ForegroundColor = cachedConsoleTextColour;
            Console.Write("] " + content);
        }

        /// <summary>
        /// Writes text to the console prefixed with a cyan 'INFO' and suffixes a newline character.
        /// </summary>
        public static void LogInfoLine(string content)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("INFO");
            Console.ForegroundColor = cachedConsoleTextColour;
            Console.Write("] " + content + "\n");
        }

        /// <summary>
        /// Writes text to the console prefixed with a yellow 'WARNING'.
        /// </summary>
        public static void LogWarning(string content)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WARNING");
            Console.ForegroundColor = cachedConsoleTextColour;
            Console.Write("] " + content);
        }

        /// <summary>
        /// Writes text to the console prefixed with a yellow 'WARNING' and suffixes a newline character.
        /// </summary>
        public static void LogWarningLine(string content)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WARNING");
            Console.ForegroundColor = cachedConsoleTextColour;
            Console.Write("] " + content + "\n");
        }

        /// <summary>
        /// Writes text to the console prefixed with a red 'ERROR'.
        /// </summary>
        public static void LogError(string content)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR");
            Console.ForegroundColor = cachedConsoleTextColour;
            Console.Write("] " + content);
        }

        /// <summary>
        /// Writes text to the console prefixed with a red 'ERROR' and suffixes a newline character.
        /// </summary>
        public static void LogErrorLine(string content)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR");
            Console.ForegroundColor = cachedConsoleTextColour;
            Console.Write("] " + content + "\n");
        }

        #endregion

        #region Console Utility Methods

        /// <summary>
        /// Forces the application to close, even if background tasks are running.
        /// </summary>
        public static void Exit()
        {
            Process.GetCurrentProcess().Kill();
        }

        #endregion
    }
}
