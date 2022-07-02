using System;

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

        #endregion
    }
}
