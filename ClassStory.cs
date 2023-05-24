using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    public class ClassStory
    {
        public int StoryId { get; set; }
        public string StoryText { get; set; }
        public DateTime StoryTime { get; set; }
        public int StoryBackground { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public System.Drawing.Font StoryFont { get; set; }
        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int StoryFontSize { get; set; }
        public int UserId { get; set; }
    }
}
