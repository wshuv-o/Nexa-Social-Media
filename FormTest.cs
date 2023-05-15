using media.Classes;
using media.Friends;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace media
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            Methods.SetDoubleBuffer(panel1, true);
            string Server = "aws.connect.psdb.cloud; Database = test; user = 3i5woql7w37mp4y7mgqp; password = pscale_pw_23Q9h3g2jlNJNl7MdqQZvpgZtpCNQl9Stje9dpgKSdF; SslMode = VerifyFull";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
