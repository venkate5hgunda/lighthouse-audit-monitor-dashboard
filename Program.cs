using System;

namespace LighthouseAuditAggregator
{
    using System.Diagnostics;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            string timeStamp = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();

            // Get the list of all valid URLs from SiteMap
            var url = "https://www.dell.com/zh-cn";
            var urlFilename = Regex.Replace(url, "[/.:]", string.Empty);
            string fileName = $"{timeStamp}_{urlFilename}.json";

            // Writing output to JSON directly with no manipulation
            var cmdString = $"/C lighthouse {url} --output=json --output-path=./auditLogs/{fileName} & exit";
            var cmdStringTwo = $"/C lighthouse {url} --output=json";

            // System.Diagnostics.Process.Start("CMD.exe", cmdString);
            JsonInputReader inputReader = new JsonInputReader();

            try
            {
                string outputStr;
                StringBuilder outputString = new StringBuilder();
                using (Process cmdProcess = new Process())
                {
                    ProcessStartInfo processStartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = cmdStringTwo,
                        RedirectStandardOutput = true
                    };
                    cmdProcess.StartInfo = processStartInfo;

                    // cmdProcess.OutputDataReceived += (sender, eventArgs) => outputString.AppendLine(eventArgs.Data);
                    cmdProcess.Start();
                    outputStr = cmdProcess.StandardOutput.ReadToEnd();

                    // Task<string> output = cmdProcess.StandardOutput.ReadToEndAsync();
                    // string outputString = await output;
                    // Console.WriteLine(outputStr + " Output Received");
                    inputReader.PushToLog(outputStr);
                    cmdProcess.WaitForExit();

                    // cmdProcess.Kill();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Suppressed Error: {0}", ex);
            }
        }
    }
}
