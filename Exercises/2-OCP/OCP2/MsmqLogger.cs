using System;

namespace OCP2
{
    public class MsmqLogger
    {
        public void Log(string log)
        {
            Console.WriteLine($"MSMQ Log: {log}");
        }
    }
}