using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DBDRandomizer
{
    class Common
    {
        public static void LoadImages(string location, ListView list)
        {
            var perkImages = Directory.EnumerateFiles(location);
            foreach (string perk in perkImages)
            {
                var perkName = perk.Replace('_', ' ');
                perkName = perkName.Replace(location, "");
                perkName = perkName.Substring(0, perkName.LastIndexOf('.'));
                ListViewItem listItem = new ListViewItem(perkName);

                Image perkImage = Image.FromFile(perk);
                list.LargeImageList.Images.Add(perkName, perkImage);
                listItem.ImageIndex = list.LargeImageList.Images.Count - 1;
                list.SmallImageList.Images.Add(perkName, perkImage);
                listItem.ImageIndex = list.SmallImageList.Images.Count - 1;

                list.Items.Add(listItem);
            }
        }

        public class Perk
        {
            public Image Img { get; set; }
            public string Name { get; set; }
        }

        private static List<string> previousPerks = new List<string>();

        public static List<Perk> RandomizePerks(int count, ListView list, bool uniquePerks)
        {
            Random r = new Random();
            int picksLeft = count;

            List<Perk> allPerks = new List<Perk>();
            List<Perk> selectedPerks = new List<Perk>();

            // If there weren't previous perks, don't bother checking
            if (previousPerks == null)
            {
                uniquePerks = false;
            }

            // If there aren't enough perks selected to have a full set, ignore this
            if (previousPerks.Count + count > list.CheckedItems.Count)
            {
                uniquePerks = false;
            }

            foreach (ListViewItem perk in list.CheckedItems)
            {
                Image img = list.SmallImageList.Images[perk.ImageIndex];
                string name = perk.Text;

                // Filter out perks that were selected the previous roll, if that's asked for
                if (uniquePerks == false || !previousPerks.Contains(name))
                {
                    allPerks.Add(new Perk { Img = img, Name = name });
                }
            }

            previousPerks.Clear();

            while (allPerks.Count > 0 && picksLeft > 0)
            {
                int nextIndex = r.Next(allPerks.Count);
                Perk nextPerk = allPerks[nextIndex];
                selectedPerks.Add(nextPerk);
                previousPerks.Add(nextPerk.Name);
                allPerks.RemoveAt(nextIndex);

                picksLeft -= 1;
            }

            return selectedPerks;
        }
    }
}
