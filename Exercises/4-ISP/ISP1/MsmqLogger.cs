using System;

namespace ISP1
{
    public class MsmqLogger
    {
        public void Log(string log)
        {
            Console.WriteLine($"MSMQ Log: {log}");
        }
    }
}