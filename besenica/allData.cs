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
        public static List<char> letters = new List<char>() {  'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П',
    'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ь', 'Ю', 'Я',
    'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п',
    'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ь', 'ю', 'я', ' ', '-'};

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
