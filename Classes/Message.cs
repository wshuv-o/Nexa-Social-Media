using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public DateTime SendTime { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }

        public Message(int messageId, string messageText, DateTime sendTime, int senderId, int receiverId)
        {
            MessageId = messageId;
            MessageText = messageText;
            SendTime = sendTime;
            SenderId = senderId;
            ReceiverId = receiverId;
        }
    }
}
