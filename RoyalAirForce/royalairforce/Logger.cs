using System;

namespace royalairforce
{
    public class Logger {
        private static Logger instance = new Logger();

        public static Logger GetInstance() {
            return instance;
        }

        public static bool CONSOLE_LOG = true;

        public Logger() {
        }

        public void Info(string info) {
            if (CONSOLE_LOG) {
                Console.WriteLine(info);
            }
        }
    }
}