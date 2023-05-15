using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class Formtessst : Form
    {
        public Formtessst()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emoji = richTextBox1.Text;label1.UseCompatibleTextRendering = true;
            label1.Text = emoji;
/*            string emo = this.richTextBox1.Text;
            
            this.label1.Text = emo ;*/
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
