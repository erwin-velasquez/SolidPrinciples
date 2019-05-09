using System;

namespace DIP
{
    public class MsmqLogger : ILogger
    {
        public void Log(string log)
        {
            Console.WriteLine($"MSMQ Log: {log}");
        }
    }
}