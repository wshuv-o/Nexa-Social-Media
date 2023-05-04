using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms;

namespace media
{
    public partial class PostControl : UserControl
    {
        private Post post;

        public PostControl(Post post)
        {
            InitializeComponent();
            this.post = post;
            // Add code to initialize the user control's appearance and layout here
        }

        private void PostControl_Load(object sender, EventArgs e)
        {

        }

        // Add event handlers and other methods for the user control here
    }
}

