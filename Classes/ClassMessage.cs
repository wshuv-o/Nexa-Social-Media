using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    internal class ClassMessage
    {
        private int messageId;
        private DateTime messageTime;
        private string message;
        private ClassMedia[] classMedias;
        public int MessageId
        {
            get { return this.messageId; }
            set { this.messageId = value; }
        }
        public DateTime MessageTime
        {
            get { return this.messageTime; }
            set { this.messageTime = value; }
        }
        public ClassMedia[] ClassMedias
        {
            get { return this.classMedias;}
            set
            {
                this.classMedias = value;
            }
        }
        public string Message
        {
            get { return this.message; }
            set
            {
                this.message = value;
            }
        }
        public ClassMessage(int messageId, DateTime messageTime, string message)
        {
            this.MessageId = messageId;
            this.MessageTime = messageTime;
            this.Message = message;
        }
        public ClassMessage(int messageId, DateTime messageTime, string message, ClassMedia[] classMedias)
        {
            this.MessageId = messageId;
            this.MessageTime = messageTime;
            this.Message = message;
            this.ClassMedias = classMedias;
        }
    }
}
