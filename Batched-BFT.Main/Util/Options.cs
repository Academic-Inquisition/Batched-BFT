using CommandLine;

namespace Batched_BFT.Util
{
    public class Options
    {
        // Runtime Options
        [Option('n', "nodes", HelpText = "The amount of Nodes to run [Default: 5]", Required = false)]
        public int Nodes { get; set; } = 4;

        [Option('r', "rounds", HelpText = "The amount of rounds to run [Default: 10000]", Required = false)]
        public int Rounds { get; set; } = 10000;

        [Option('l', "leader", HelpText = "Should leader-checking be enabled? [Default: false]", Required = false)]
        public string EnableLeaderChecking { get; set; } = "false";

        public bool IsLeaderCheckingEnabled()
        {
            return EnableLeaderChecking == "true";
        }

        // Output Options
        [Option('p', "path", HelpText = "Default output path for the finalized file with times [Default: ./output/]", Required = false)]
        public string Output_Path { get; set; } = $"./output/";

        // Debug
        [Option('d', "debug", HelpText = "Enable Debug Logging [Default: false]", Required = false)]
        public string Debug { get; set; } = "false";

        public bool IsDebugEnabled()
        {
            return Debug == "true";
        }
    }
}
