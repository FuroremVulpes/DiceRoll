using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class Main_window : Form
    {
        public Main_window() => InitializeComponent();

        private void Wain_window_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ChangeCustomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomType ct = new CustomType();
            ct.ShowDialog();
        }

        private void GroupManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupManaging gm = new GroupManaging();
            gm.ShowDialog();
        }

        private void AddGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grouping gr = new Grouping();
            gr.ShowDialog();
        }
    }
}
