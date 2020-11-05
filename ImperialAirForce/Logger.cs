using System;

namespace ImperialAirForce
{
    public class Logger {
        private static Logger instance = new Logger();

        public static Logger GetInstance() {
            return instance;
        }

        public static bool LOG_TO_CONSOLE;

        public Logger() {
        }

        public void Info(string info) {
            if (LOG_TO_CONSOLE) {
                Console.WriteLine(info);
            }
        }
    }
}