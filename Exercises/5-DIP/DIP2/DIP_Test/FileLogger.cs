using System;
using Xunit;
using DIP;

namespace DIP_Test
{
    public class FileLogger : ILogger
    {
        public void Log(string log)
        {
            Console.WriteLine($"File Log: {log}");
        }
    }
}