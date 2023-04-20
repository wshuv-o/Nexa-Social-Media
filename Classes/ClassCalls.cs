using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    internal class ClassCalls
    {
        private DateTime callDate;
        private string duration;
        private bool isVideoOn;
        private bool isMicOn;
        public DateTime CallDate
        {
            get { return this.callDate; }
            set { this.callDate = value; }
        }
        public string Duration
        {
            get 
            {
                TimeSpan timeSpane = (DateTime.Now - this.callDate);
                return timeSpane.ToString(@"hh\:mm\:ss"); 
            }
        }

        public bool IsVideoOn
        {
            get { return this.isVideoOn; }
            set { this.isVideoOn = value;}
        }
        public bool IsMicOn
        {
            get { return this.isMicOn;}
            set
            {
                this.isMicOn = value;
            }
        }
        public ClassCalls(DateTime callDate, bool isVideoOn, bool isMicOn)
        {
            CallDate = callDate;
            IsVideoOn = isVideoOn;
            IsMicOn = isMicOn;
        }
    }
}
