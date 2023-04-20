using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    internal class PersonalWebsites
    {
        private string link;
        private string name;
        private Image logo;
        public string Link
        {
            get { return this.link; }
            set { this.link = value; }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if ((Link.ToLower()).Contains("facebook")) this.name = "Facebook";
                else if (Link.Contains("whatsapp")) this.name = "Whatsapp";
                else if (Link.Contains("linkedin")) this.name = "LinkedIn";
                else if (Link.Contains("instagram")) this.name = "Instagram";
                else if (Link.Contains("twiter")) this.name = "Twiter";
                else this.name = "Unidentified";
            }
        }
        public Image Logo
        {
            get { return this.logo; }
            set { 
                if (this.Name == "Facebook") this.logo = global::media.Properties.Resources.facebook; 
                if (this.Name == "LinkedIn") this.logo = global::media.Properties.Resources.linkedin;
                if (this.Name == "Instagram") this.logo = global::media.Properties.Resources.instagram;
                else this.logo = global::media.Properties.Resources.logo;
            }
        }

    }
}
