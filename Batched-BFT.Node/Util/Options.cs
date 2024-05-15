using CommandLine;

namespace Batched_BFT.Node.Util
{
    public class Options
    {
        // Runtime Options
        [Option('p', "port", HelpText = "What port to connect the WebSocket to [Default: 8080]", Required = false)]
        public int ServerPort { get; set; } = 8080;

        [Option('n', "nodeId", HelpText = "Id of the Node [Default: -1]", Required = false)]
        public int NodeId { get; set; } = -1;

        // Debug
        [Option('d', "debug", HelpText = "Enable Debug Logging [Default: false]", Required = false)]
        public string Debug { get; set; } = "false";

        public bool IsDebugEnabled()
        {
            return Debug == "true";
        }
    }
}
