using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace besenica
{
    public static class allData
    {
        public static List<Words> allWords { get; set; } = new List<Words>();
        public static List<string> categories { get; set; } = new List<string>();

        public static void updateAllCombo(ComboBox a)
        {
            a.Items.Clear();
            foreach (string cat in categories)
            {
                a.Items.Add(cat);
            }
            a.SelectedIndex = 0;
        }
    }
}
