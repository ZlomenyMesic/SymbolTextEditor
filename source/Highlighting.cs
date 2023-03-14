using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HighQualityTextEditor {
    internal static class Highlighting {
        public static Color keywordColorMain = Color.FromArgb(200, 21, 80);
        public static Color keywordColor = Color.FromArgb(23, 80, 200);
        public static Color methodColor = Color.FromArgb(173, 114, 26);
        public static Color classColor = Color.FromArgb(54, 163, 130);
        public static Color commentColor = Color.FromArgb(48, 128, 48);
        public static Color stringColor = Color.FromArgb(255, 123, 41);
        public static Color textColor = Color.Black;

        public static void HighlightKeyword(string word, Color color, Form1 form1) {
            if (form1.textBoxMain.Text.Contains(word)) {
                List<int> indexes = new List<int>();
                for (int i = form1.textBoxMain.Text.IndexOf(word); i != -1; i = form1.textBoxMain.Text.IndexOf(word, i + 1))
                    indexes.Add(i);

                foreach (int i in indexes) {
                    int index = i;
                    int length = word.Length;
                    bool end = false;

                    foreach (char c in word) {
                        if (Regex.IsMatch(c.ToString(), RegularExpressions.regexSpecChar) && !end) {
                            index++;
                            length--;
                        }
                        else if (!Regex.IsMatch(c.ToString(), RegularExpressions.regexSpecChar)) end = true;
                        else if (Regex.IsMatch(c.ToString(), RegularExpressions.regexSpecChar) && end) length--;
                    }
                    form1.textBoxMain.Select(index, length);
                    form1.textBoxMain.SelectionColor = color;
                }
            }
        }

        public static void HighlightString(string str, Color color, Form1 form1, bool remSpecChar) {
            if (form1.textBoxMain.Text.Contains(str)) {
                if (remSpecChar)
                    str = str.Replace("{", "").TrimEnd(); ;

                int from = 0;
                int startIndex = form1.textBoxMain.Text.IndexOf(str, from);
                int length = str.Length;

                while (startIndex != -1) {

                    form1.textBoxMain.Select(startIndex, length);
                    form1.textBoxMain.SelectionColor = color;

                    from += length;
                    startIndex = form1.textBoxMain.Text.IndexOf(str, from);
                }
            }
        }

        public static void FindQuotes(Form1 form1) {
            List<string> result = form1.textBoxMain.Text.Split('"').Where((s, i) => i % 2 == 1).ToList();

            foreach (string str in result)
                HighlightString($"\"{str}\"", stringColor, form1, false);
        }

        public static void UpdateTextBox(Form1 form1) {
            form1.textBoxMain.BeginUpdate();

            int cursorPos = form1.textBoxMain.SelectionStart;
            form1.textBoxMain.SelectAll();
            form1.textBoxMain.SelectionColor = textColor;

            List<string> mainKeywords= new List<string> { "public", "static", "class" };
            List<string> keywords = new List<string> { "return", "if", "else", "int", "string", "void" };

            RegularExpressions.FindNames(form1, classColor, false);
            RegularExpressions.FindClassDeclaration(form1, classColor);

            foreach (string keyword in mainKeywords)
                RegularExpressions.FindKeyword(form1, keyword, keywordColorMain);
            foreach (string keyword in keywords)
                RegularExpressions.FindKeyword(form1, keyword, keywordColor);

            RegularExpressions.FindNames(form1, methodColor, true);
            RegularExpressions.FindComments(form1, commentColor);
            FindQuotes(form1);

            form1.textBoxMain.Select(cursorPos, cursorPos);
            form1.textBoxMain.DeselectAll();

            form1.textBoxMain.EndUpdate();
        }
    }
}
