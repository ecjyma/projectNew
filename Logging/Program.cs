using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Practices.Infrastructure;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging;



namespace Logging
{
    class Program
    {
        static void Main(string[] args) 
        {

            LogEntry entry = new LogEntry();
            entry.Priority = 1;
            entry.Categories.Add("C#学习");
            entry.Title = "标题";
            entry.Message = "test";
            Logger.Write(entry);

            //LogEntry logEntry = new LogEntry();
            //logEntry.EventId = 1;
            //logEntry.Priority = 1;
            //logEntry.Severity = System.Diagnostics.TraceEventType.Error;
            //logEntry.Title = "标题";
            //logEntry.Message = "test";
            //logEntry.Categories.Add("C#学习");
            //logEntry.Categories.Add("Microsoft Enterprise Library学习");

            //Logger.Writer.Write(logEntry);

            //  Logger.Writer.Write(logEntry, "General");
            Console.WriteLine("日志写入完成!");



        }
    }
}
