using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HighQualityTextEditor {
    internal static class RegularExpressions {
        public const string regexKeywordFirst = @"(^|[^\w])";
        public const string regexKeywordSecond = @"($|[^\w])";
        public const string regexMethod = @"(\s|\.)\w{1,}[^\s]\(";
        public const string regexClassCall = @"(\.|\(|\s)\w{1,}[^\s]\.";
        public const string regexClass = @"class \w{1,}[^\s](\s|\{)";
        public const string regexComment = @"//(\w|\W)[^\n]{0,}(\n|$)";
        public const string regexSpecChar = @"(\W|\s)";

        public static void FindKeyword(Form1 form1, string keyword, Color color) {
            MatchCollection matches = Regex.Matches(form1.textBoxMain.Text, $"{regexKeywordFirst}{keyword}{regexKeywordSecond}", RegexOptions.Compiled);
            foreach (Match match in matches) {
                Highlighting.HighlightKeyword(keyword, color, form1);
            }
        }

        public static void FindClassDeclaration(Form1 form1, Color color) {
            MatchCollection matches = Regex.Matches(form1.textBoxMain.Text, regexClass, RegexOptions.Compiled);
            foreach (Match match in matches) {
                Highlighting.HighlightString(match.Value, color, form1, true);
            }
        }

        public static void FindComments(Form1 form1, Color color) {
            MatchCollection matches = Regex.Matches(form1.textBoxMain.Text, regexComment, RegexOptions.Compiled);
            foreach (Match match in matches) {
                if (!match.Value.Remove(match.Value.Length - 1, 1).Contains("\n")) {
                    Highlighting.HighlightString(match.Value, color, form1, false);
                    int index = form1.textBoxMain.Text.IndexOf(match.Value);
                    while (index != -1) {
                        for (int i = index; i < index + match.Value.Length; i++)
                            Highlighting.isCommentedOut.Add(i);
                        index = form1.textBoxMain.Text.IndexOf(match.Value, index + match.Value.Length);
                    }
                }
            }
        }

        public static void FindNames(Form1 form1, Color color, bool method) {
            MatchCollection matches = Regex.Matches(form1.textBoxMain.Text, method ? regexMethod : regexClassCall, RegexOptions.Compiled);
            foreach (Match match in matches) {
                Highlighting.HighlightKeyword(match.Value, color, form1);
            }
        }
    }
}
