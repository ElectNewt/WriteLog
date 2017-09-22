using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WriteLog
{
    public class WriteLog
    {

        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Debug(string text, int titlelevel = 0, bool saveLog4Net = false)
        {
            Writeline(text, ConsoleColor.White, titlelevel, LogType.Debug, saveLog4Net);
        }

        public static void Info(string text, int titlelevel = 0, bool saveLog4Net = false)
        {
            Writeline(text, ConsoleColor.Cyan, titlelevel, LogType.Info, saveLog4Net);
        }

        public static void Working(string text, int titlelevel = 0, bool saveLog4Net = false)
        {
            Writeline(text, ConsoleColor.Gray, titlelevel, LogType.Info, saveLog4Net);
        }

        public static void Success(string text, int titlelevel = 0)
        {
            Writeline(text, ConsoleColor.Green, titlelevel, LogType.Success, true);
        }

        public static void Warning(string text, int titlelevel = 0, Exception e = null)
        {
            Writeline(text + (e == null ? "" : e.ToString()), ConsoleColor.DarkYellow, titlelevel, LogType.Warning, true);
        }

        public static void Error(string text, int titlelevel = 0, Exception e = null)
        {
            Writeline(text + (e == null ? "" : e.ToString()), ConsoleColor.Red, titlelevel, LogType.Error, true);
        }

        public static void Fatal(string text, int titlelevel = 0, Exception e = null)
        {
            Writeline(text + (e == null ? "" : e.ToString()), ConsoleColor.Red, titlelevel, LogType.Fatal, true);
        }

        private static void Writeline(string text, ConsoleColor colour, int titlelevel = 0, LogType logtype = LogType.Debug, bool log4net = true)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(CalculateSpaces(titlelevel) + text);
            Console.ResetColor();

            if (log4net)
                Logger(text, logtype);
        }

        private static string CalculateSpaces(int titlelevel)
        {
            var lvl = "";
            for (var counter = 0; counter < titlelevel; counter++)
                lvl += ".";

            return lvl + " ";
        }

        private static void Logger(string text, LogType logtype)
        {
            switch (logtype)
            {
                case LogType.Success:
                    Log.Debug(text);
                    break;
                case LogType.Debug:
                    Log.Debug(text);
                    break;
                case LogType.Info:
                    Log.Info(text);
                    break;
                case LogType.Warning:
                    Log.Warn(text);
                    break;
                case LogType.Error:
                    Log.Error(text);
                    break;
                case LogType.Fatal:
                    Log.Fatal(text);
                    break;
            }
        }
    }
}
