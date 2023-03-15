using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityTextEditor {
    internal static class AutoBrackets {
        public static char lastChar = '\0';
        public static int lastIndex = 0;
        public static int oldLength = 0;
        public static int curLength = 0;

        public static void AddBrackets(Form1 form1) {
            curLength = form1.textBoxMain.Text.Length;
            lastIndex = form1.textBoxMain.SelectionStart;
            if (lastIndex == 0 || oldLength > curLength) {
                oldLength = curLength;
                return;
            }

            lastChar = form1.textBoxMain.Text[lastIndex - 1];
            Dictionary<char, char> brackets = new Dictionary<char, char> {
                {'{', '}'}, {'(', ')'}, { '\"', '\"' }, { '\'', '\'' }
            };
            foreach (char key in brackets.Keys)
                if (lastChar == key)
                    form1.textBoxMain.Text = form1.textBoxMain.Text.Insert(lastIndex, brackets[key].ToString());

            form1.textBoxMain.Select(lastIndex, lastIndex);

            curLength = form1.textBoxMain.Text.Length;
            oldLength = curLength;
        }
    }
}
