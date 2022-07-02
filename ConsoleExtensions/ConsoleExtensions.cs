using System;

namespace ConsoleExtensions
{
    public static class ConsoleExtensions
    {
        #region Properties

        private static ConsoleColor cachedConsoleTextColour;
        private static ConsoleColor cachedConsoleBackgroundColour;

        #endregion

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
    }
}
