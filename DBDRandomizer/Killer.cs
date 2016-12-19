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
    public partial class Killer : Form
    {
        public Killer()
        {
            InitializeComponent();

            perkList.SmallImageList = new ImageList();
            perkList.LargeImageList = new ImageList();
            perkList.SmallImageList.ImageSize = new Size(64, 64);
            perkList.LargeImageList.ImageSize = new Size(64, 64);
        }

        private void Killer_Load(object sender, EventArgs e)
        {
            string imageLocation = "Assets\\Killer\\";
            Common.LoadImages(imageLocation, perkList);
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in perkList.Items)
            {
                item.Checked = true;
            }
        }

        private void selectNoneButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in perkList.Items)
            {
                item.Checked = false;
            }
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            var selectedPerks = Common.RandomizePerks(4, perkList);
            PictureBox[] pictures = { perkImage1, perkImage2, perkImage3, perkImage4 };
            Label[] labels = { perkLabel1, perkLabel2, perkLabel3, perkLabel4 };

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
