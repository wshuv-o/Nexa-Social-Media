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
            // Assuming you have a TableLayoutPanel called 'tableLayoutPanel2'
            int removeColumnIndex = 0;
            int removeRowIndex = 2;

            Control controlToRemove = tableLayoutPanel2.GetControlFromPosition(removeColumnIndex, removeRowIndex);
            if (controlToRemove != null)
            {
                tableLayoutPanel2.Controls.Remove(controlToRemove);
                controlToRemove.Dispose();

                // Adjust the layout by shifting controls in the same column above the removed cell
                for (int rowIndex = removeRowIndex + 1; rowIndex < tableLayoutPanel2.RowCount; rowIndex++)
                {
                    Control control = tableLayoutPanel2.GetControlFromPosition(removeColumnIndex, rowIndex);
                    if (control != null)
                    {
                        tableLayoutPanel2.SetCellPosition(control, new TableLayoutPanelCellPosition(removeColumnIndex, rowIndex - 1));
                    }
                }

                // Update the row span of the control in the adjacent cell
                Control adjacentControl = tableLayoutPanel2.GetControlFromPosition(removeColumnIndex, removeRowIndex - 1);
                if (adjacentControl != null)
                {
                    tableLayoutPanel2.SetRowSpan(adjacentControl, tableLayoutPanel2.GetRowSpan(adjacentControl) + 1);
                }

                // Decrement the row count of the table layout
                tableLayoutPanel2.RowCount--;
            }
        }
    }
}
