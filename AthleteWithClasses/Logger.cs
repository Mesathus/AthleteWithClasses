using System;
using System.IO;

namespace AthleteWithClasses
{
    static class Logger
    {     
        private static DirectoryInfo ResetDir()
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            DirectoryInfo logDir = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "Logs"));
            if (!logDir.Exists) Directory.CreateDirectory(logDir.ToString());
            return logDir;
        }

        public static bool LogEvent(Exception error)
        {
            try
            {
                DirectoryInfo logPath = ResetDir();
                string currDate = DateTime.Today.ToString();
                string logName = logPath.ToString() + "\\" + currDate + ".txt";
                using (StreamWriter outputFile = new StreamWriter(logName))
                {
                    string currTime = DateTime.Now.ToString();
                    outputFile.WriteLine(string.Format("Error logged at time {0}, message as follows: {1}", currTime, error.Message));
                }
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

    }


}
