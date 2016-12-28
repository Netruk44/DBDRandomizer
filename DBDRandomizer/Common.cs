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

        public static List<Perk> RandomizePerks(int count, ListView list, bool uniquePerks, bool duplicates)
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
            Perk lastPerk = null;

            while (allPerks.Count > 0 && picksLeft > 0)
            {
                if(duplicates && lastPerk != null)
                {
                    // Check to see if this should be a duplicate.
                    // Set chance to use the previous perk works better than just relying on random chance to select
                    // the same perk twice. This makes it vastly more likely for it to be 'interesting' (3 or 4 of the same perk)


                    // Statistics for a 25% chance to select the previous perk:
                    //   - Chance for there to be 4 of the same perk: ~2%
                    //       1 1 1 1 - 1.6% chance
                    //   - Chance for there to be 3 of the same perk: ~9%
                    //       1 1 1 2 - 4.7% chance
                    //       1 2 2 2 - 4.7% chance
                    //   - Chance for there to be 2 of the same perk: ~42%
                    //       1 1 2 3 - 14% chance
                    //       1 2 2 3 - 14% chance
                    //       1 2 3 3 - 14% chance
                    //   - Chance for there to be 2 groups of 2:      ~5%
                    //       1 1 2 2 - 4.7% chance
                    //   - Chance for there to be all unique perks:   ~42%
                    //       1 2 3 4 - 42.1% chance

                    // Statistics for a 40% chance to select the previous perk:
                    //   - Chance for there to be 4 of the same perk: ~6%
                    //   - Chance for there to be 3 of the same perk: ~19%
                    //   - Chance for there to be 2 of the same perk: ~43%
                    //   - Chance for there to be 2 groups of 2:      ~10%
                    //   - Chance for there to be all unique perks:   ~22%

                    if (r.Next(10) < 4)
                    {
                        selectedPerks.Add(lastPerk);
                        picksLeft -= 1;
                        continue;
                    }
                }

                int nextIndex = r.Next(allPerks.Count);
                Perk nextPerk = allPerks[nextIndex];
                selectedPerks.Add(nextPerk);
                previousPerks.Add(nextPerk.Name);
                allPerks.RemoveAt(nextIndex);
                lastPerk = nextPerk;

                picksLeft -= 1;
            }

            return selectedPerks;
        }
    }
}
