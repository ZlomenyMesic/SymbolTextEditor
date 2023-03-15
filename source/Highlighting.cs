using System;
using System.Collections.Generic;
using System.IO;
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

        public static List<string> mainKeywords = new List<string> { "public", "static", "class" };
        public static List<string> keywords = new List<string> { "return", "if", "else", "int", "string", "void", "new", "true", "false" };

        public static List<string> classNames = new List<string>();
        public static List<int> isCommentedOut = new List<int>();
        public static List<int> isString = new List<int>();

        public static void HighlightKeyword(string word, Color color, Form1 form1) {
            if (form1.textBoxMain.Text.Contains(word)) {
                int index = form1.textBoxMain.Text.IndexOf(word);
                while (index != -1) {
                    int i = index;
                    int length = word.Length;
                    bool end = false;

                    if (!isString.Contains(i) && !isCommentedOut.Contains(i)) {
                        foreach (char c in word) {
                            if (Regex.IsMatch(c.ToString(), RegularExpressions.regexSpecChar) && !end) {
                                i++;
                                length--;
                            } else if (!Regex.IsMatch(c.ToString(), RegularExpressions.regexSpecChar)) end = true;
                            else if (Regex.IsMatch(c.ToString(), RegularExpressions.regexSpecChar) && end) length--;
                        }
                        form1.textBoxMain.Select(i, length);
                        form1.textBoxMain.SelectionColor = color;
                    }
                    index = form1.textBoxMain.Text.IndexOf(word, index + word.Length);
                }
            }
        }

        public static void HighlightString(string str, Color color, Form1 form1, bool isClass) {
            if (form1.textBoxMain.Text.Contains(str)) {
                if (isClass) {
                    str = str.Replace("{", "").Trim();
                }

                int index = form1.textBoxMain.Text.IndexOf(str);

                while (index != -1) {
                    if ((isClass && !isString.Contains(index) && !isCommentedOut.Contains(index)) || !isClass) {
                        if (isClass) classNames.Add(str.Remove(0, 6));
                        form1.textBoxMain.Select(index + (isClass ? 6 : 0), str.Length - (isClass ? 6 : 0));
                        form1.textBoxMain.SelectionColor = color;
                    }
                    index = form1.textBoxMain.Text.IndexOf(str, index + str.Length);
                }
            }
        }

        public static void HighlightInstanceCreation(string str, Color color, Form1 form1) {
            int index = form1.textBoxMain.Text.IndexOf(str);
            while (index > 0) {
                if (index + str.Length + 1 < form1.textBoxMain.Text.Length) {
                    string sub = form1.textBoxMain.Text.Substring(index - 1, str.Length + 2);
                    if (Regex.IsMatch(sub, $"{RegularExpressions.regexKeywordFirst}{str}{RegularExpressions.regexKeywordSecond}")) {
                        form1.textBoxMain.Select(index, str.Length);
                        form1.textBoxMain.SelectionColor = color;
                    }
                }
                index = form1.textBoxMain.Text.IndexOf(str, index + str.Length);
            }
        }

        public static void FindQuotes(Form1 form1, char quote) {
            List<string> result = form1.textBoxMain.Text.Split(quote).Where((s, i) => i % 2 == 1).ToList();

            foreach (string str in result) {
                string fullStr = $"{quote}{str}{quote}";
                HighlightString(fullStr, stringColor, form1, false);
                int index = form1.textBoxMain.Text.IndexOf(fullStr);
                while (index != -1) {
                    for (int i = index; i < index + fullStr.Length; i++)
                        isString.Add(i);
                    index = form1.textBoxMain.Text.IndexOf(fullStr, index + fullStr.Length);
                }
            }
        }

        public static void UpdateTextBox(Form1 form1) {
            form1.textBoxMain.BeginUpdate();

            int cursorPos = form1.textBoxMain.SelectionStart;
            form1.textBoxMain.SelectAll();
            form1.textBoxMain.SelectionColor = textColor;

            RegularExpressions.FindComments(form1, commentColor);
            FindQuotes(form1, '\"');
            FindQuotes(form1, '\'');

            Console.Clear();
            RegularExpressions.FindNames(form1, classColor, false);
            RegularExpressions.FindClassDeclaration(form1, classColor);

            foreach (string keyword in mainKeywords)
                RegularExpressions.FindKeyword(form1, keyword, keywordColorMain);
            foreach (string keyword in keywords)
                RegularExpressions.FindKeyword(form1, keyword, keywordColor);

            RegularExpressions.FindNames(form1, methodColor, true);

            foreach (string s in classNames)
                HighlightInstanceCreation(s, classColor, form1);

            FindQuotes(form1, '\"');
            FindQuotes(form1, '\'');

            classNames.Clear();
            isString.Clear();
            isCommentedOut.Clear();

            form1.textBoxMain.Select(cursorPos, cursorPos);
            form1.textBoxMain.DeselectAll();

            form1.textBoxMain.EndUpdate();
        }
    }
}
