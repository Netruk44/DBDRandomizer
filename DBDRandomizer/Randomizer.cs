using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBDRandomizer
{
    public partial class Randomizer : Form
    {
        public Randomizer()
        {
            InitializeComponent();

            survivorPerkList.SmallImageList = new ImageList();
            survivorPerkList.SmallImageList.ImageSize = new Size(64, 64);
            killerPerkList.SmallImageList = new ImageList();
            killerPerkList.SmallImageList.ImageSize = new Size(64, 64);
        }

        private void onlyNewPerksEveryRollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Randomizer_Load(object sender, EventArgs e)
        {
            string survivorImageLocation = "Assets\\Survivor\\";
            string killerImageLocation = "Assets\\Killer\\";

            Common.LoadImages(survivorImageLocation, survivorPerkList);
            Common.LoadImages(killerImageLocation, killerPerkList);
        }

        private void survivorSelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in survivorPerkList.Items)
            {
                item.Checked = true;
            }
        }

        private void survivorSelectNoneButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in survivorPerkList.Items)
            {
                item.Checked = false;
            }
        }

        private void killerSelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in killerPerkList.Items)
            {
                item.Checked = true;
            }
        }

        private void killerSelectNoneButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in killerPerkList.Items)
            {
                item.Checked = false;
            }
        }

        private void survivorRandomizeButton_Click(object sender, EventArgs e)
        {
            var selectedPerks = Common.RandomizePerks(4, survivorPerkList, onlyNewPerksEveryRollToolStripMenuItem.Checked);
            PictureBox[] pictures = { survivorPerkImage1, survivorPerkImage2, survivorPerkImage3, survivorPerkImage4 };
            Label[] labels = { survivorPerkLabel1, survivorPerkLabel2, survivorPerkLabel3, survivorPerkLabel4 };

            for (int i = 0; i < selectedPerks.Count; i++)
            {
                pictures[i].Image = selectedPerks[i].Img;
                labels[i].Text = selectedPerks[i].Name;
            }

            for (int i = selectedPerks.Count; i < 4; i++)
            {
                pictures[i].Image = null;
                labels[i].Text = "";
            }
        }

        private void killerRandomizeButton_Click(object sender, EventArgs e)
        {
            var selectedPerks = Common.RandomizePerks(4, killerPerkList, onlyNewPerksEveryRollToolStripMenuItem.Checked);
            PictureBox[] pictures = { killerPerkImage1, killerPerkImage2, killerPerkImage3, killerPerkImage4 };
            Label[] labels = { killerPerkLabel1, killerPerkLabel2, killerPerkLabel3, killerPerkLabel4 };

            for (int i = 0; i < selectedPerks.Count; i++)
            {
                pictures[i].Image = selectedPerks[i].Img;
                labels[i].Text = selectedPerks[i].Name;
            }

            for (int i = selectedPerks.Count; i < 4; i++)
            {
                pictures[i].Image = null;
                labels[i].Text = "";
            }
        }
    }
}
