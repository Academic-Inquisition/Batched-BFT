using Microsoft.Extensions.Logging;
using System.Text;

namespace Batched_BFT.Communication.Logger
{
    public class LogHelper
    {
        public static ILogger GetLogger(string name, string prefix = "", string suffix = "")
        {
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            StringBuilder builder = new StringBuilder();
            if (!prefix.Equals("")) builder.Append(prefix).Append('.');
            builder.Append(name);
            if (!suffix.Equals("")) builder.Append('.').Append(suffix);
            ILogger logger = factory.CreateLogger(builder.ToString());
            return logger;
        }
    }
}