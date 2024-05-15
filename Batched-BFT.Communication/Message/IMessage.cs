using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batched_BFT.Communication.Message
{
    public enum MessageType
    {
        Proposal = 1, 
        PrePrepare = 2, Prepare = 3, 
        Commit = 4, Response = 5
    }

    internal interface IMessage
    {
        int SenderId { get; }
        int RoundId { get; }
        List<byte[]> Messages { get; }

        IMessage Copy();
    }
}
