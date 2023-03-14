using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityTextEditor {
    internal static class Customizing {
        public static bool isDarkMode = false;
        public static void DarkMode(Form1 form1) {
            form1.textBoxMain.BeginUpdate();
            string allText = form1.textBoxMain.Text;
            form1.textBoxMain.Clear();
            isDarkMode = !isDarkMode;

            Highlighting.textColor = isDarkMode ? Color.White : Color.Black;
            Highlighting.methodColor = isDarkMode ? Color.FromArgb(228, 236, 100) : Color.FromArgb(173, 114, 26);
            Highlighting.keywordColor = isDarkMode ? Color.FromArgb(117, 180, 189) : Color.FromArgb(23, 80, 200);
            Highlighting.keywordColorMain = isDarkMode ? Color.FromArgb(220, 108, 128) : Color.FromArgb(200, 21, 80);

            form1.textBoxMain.BackColor = isDarkMode ? Color.FromArgb(30, 30, 30) : Color.White;
            form1.menuStrip1.BackColor = isDarkMode ? Color.FromArgb(40, 40, 40) : Color.White;
            form1.menuStrip1.ForeColor = Highlighting.textColor;
            form1.label1.ForeColor = Highlighting.textColor;
            form1.BackColor = isDarkMode ? Color.FromArgb(25, 25, 25) : Color.White;
            form1.splitContainer1.BackColor = isDarkMode ? Color.FromArgb(40, 40, 40) : Color.White;

            Highlighting.UpdateTextBox(form1);
            form1.textBoxMain.Text = allText;
            form1.textBoxMain.EndUpdate();
        }
    }
}
