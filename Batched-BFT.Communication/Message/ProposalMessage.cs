using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batched_BFT.Communication.Message
{
    public class ProposalMessage(int SenderId, int RoundId, List<byte[]> Messages) : IMessage
    {
        public int SenderId { get; } = SenderId;
        public int RoundId { get; } = RoundId;
        public List<byte[]> Messages { get; } = Messages;

        IMessage IMessage.Copy()
        {
            return new ProposalMessage(SenderId, RoundId, Messages);
        }
    }
}
