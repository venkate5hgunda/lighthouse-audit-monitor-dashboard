using System;
using System.Collections.Generic;
using System.Text;
using LighthouseAuditAggregator.InputReaderModel;
using System.IO;
using LighthouseAuditAggregator.OutputLoggerModel;
using Newtonsoft.Json;

namespace LighthouseAuditAggregator
{

    public class JsonInputReader
    {
        public void PushToLog(string jsonInputString)
        {
            var inputObject = InputModelRoot.FromJson(jsonInputString);
            var logItems = LogItemsGenerator(inputObject);
            WriteToTxtFile(logItems);
        }

        public List<string> LogItemsGenerator(InputModelRoot inputObject)
        {
            List<string> logItems = new List<string>();
            foreach (var auditPoint in inputObject.Audits)
            {
                OutputModelRoot logItem = new OutputModelRoot();
                logItem.AuditTitle = auditPoint.Key;
                logItem.Audit = auditPoint.Value;
                logItem.Environment = inputObject.Environment;
                logItem.FetchTime = inputObject.FetchTime;
                logItem.FinalUrl = inputObject.FinalUrl;
                logItem.LighthouseVersion = inputObject.LighthouseVersion;
                logItem.RequestedUrl = inputObject.RequestedUrl;
                logItem.UserAgent = inputObject.UserAgent;

                logItems.Add(JsonConvert.SerializeObject(logItem));
            }

            return logItems;
        }

        public void WriteToTxtFile(List<string> logItems)
        {
            //StringBuilder sb = new StringBuilder();
            //foreach (var logItem in logItems)
            //{
            //    sb.AppendLine(logItem);
            //}
            File.AppendAllLines("C:\\Users\\venkatesh_gunda\\source\\repos\\LighthouseAuditAggregator\\bin\\Debug\\netcoreapp2.2\\auditLogs\\" + "log.txt", logItems);
        }
    }
}
