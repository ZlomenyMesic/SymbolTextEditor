using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighQualityTextEditor {
    internal static class LineNumbers {
        public static int CalcLabelY(Form1 form1) {
            return form1.textBoxMain.GetPositionFromCharIndex(0).Y % (form1.textBoxMain.Font.Height + 1);
        }

        public static void UpdateNumberLabel(Form1 form1) {
            Point pos = new Point(0, 0);
            int firstIndex = form1.textBoxMain.GetCharIndexFromPosition(pos);
            int firstLine = form1.textBoxMain.GetLineFromCharIndex(firstIndex);

            pos.X = form1.ClientRectangle.Width;
            pos.Y = form1.ClientRectangle.Height;
            int lastIndex = form1.textBoxMain.GetCharIndexFromPosition(pos);
            int lastLine = form1.textBoxMain.GetLineFromCharIndex(lastIndex);

            form1.numberLabel.Text = "";
            for (int i = firstLine; i <= lastLine + 1; i++)
                if ((i != lastLine + 1) || (i == lastLine + 1 && form1.textBoxMain.Text != "" && form1.textBoxMain.Text[^1] == '\n'))
                    form1.numberLabel.Text += i + 1 + "\n"; 
        }
    }
}
