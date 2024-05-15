using System.Net.WebSockets;
using Batched_BFT.Node.Util;
using CommandLine;
using Microsoft.Extensions.Logging;
using Batched_BFT.Communication.Logger;


namespace Batched_BFT.Node
{
    internal class Program
    {
        public static Options? options { get; set; }

        public async void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args).WithParsed(z => options = z);
            if (options != null)
            {
                ILogger logger = LogHelper.GetLogger("node", "main", options.NodeId.ToString());
                Uri connectionString = new($"ws://localhost:{options.ServerPort}");
                using SocketsHttpHandler handler = new();
                using ClientWebSocket socket = new();
                logger.LogInformation($"Connecting to WebSocket Server @URI: {connectionString}");
                await socket.ConnectAsync(connectionString, new HttpMessageInvoker(handler), default);

            }
        }
    }
}
