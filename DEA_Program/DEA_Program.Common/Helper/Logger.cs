namespace DEA_Program.Common.Helper
{
    using System;
    using System.IO;
    using System.Threading.Tasks;

    public class Logger
    {
        private static readonly string LogFilePath = Path.Combine(Environment.GetFolderPath
                                                        (Environment.SpecialFolder.ApplicationData),
                                                        "app_log.txt");

        public static void Log(Exception ex, string context = "")
        {
            try
            {
                string logEntry = string.Format("[{0:yyyy-MM-dd HH:mm:ss}] {1}\n{2}\n\n",
                                                DateTime.Now,
                                                context,
                                                ex.ToString());

                File.AppendAllText(LogFilePath, logEntry);
            }
            catch
            {
                // Fails silently to avoid recursive logging problems
            }
        }

        public static string GetLogFilePath()
        {
            return LogFilePath;
        }

        public static string ReadLog()
        {
            try
            {
                if (File.Exists(LogFilePath))
                    return File.ReadAllText(LogFilePath);
                return "No logs found.";
            }
            catch
            {
                return "Failed to read logs.";
            }
        }

        public static void ClearLog()
        {
            try
            {
                if (File.Exists(LogFilePath))
                    File.Delete(LogFilePath);
            }
            catch
            {
                // Silent fail
            }
        }
    }
}
