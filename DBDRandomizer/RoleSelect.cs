using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBDRandomizer
{
    public partial class RoleSelect : Form
    {
        public RoleSelect()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void survivorButton_Click(object sender, EventArgs e)
        {
            var s = new Survivor();
            s.Show();
            s.FormClosed += (sender2, args) => this.Show();
            Hide();
        }

        private void killerButton_Click(object sender, EventArgs e)
        {
            var k = new Killer();
            k.Show();
            k.FormClosed += (sender2, args) => this.Show();
            Hide();
        }
    }
}
