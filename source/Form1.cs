using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace HighQualityTextEditor {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Customizing.DarkMode(this);
        }

        private void NewFile(object sender, EventArgs e) {
            Files.New(this);
        }

        private void Exit(object sender, EventArgs e) {
            Files.Exit();
        }

        private void OpenFile(object sender, EventArgs e) {
            Files.Open(this);
        }

        private void Save(object sender, EventArgs e) {
            Files.Save(this);
        }

        private void SaveAs(object sender, EventArgs e) {
            Files.SaveAs(this);
        }

        #region EDIT
        private void Undo(object sender, EventArgs e) {
            textBoxMain.Undo();
        }

        private void Redo(object sender, EventArgs e) {
            textBoxMain.Redo();
        }

        private void Cut(object sender, EventArgs e) {
            textBoxMain.Cut();
        }

        private void Copy(object sender, EventArgs e) {
            textBoxMain.Copy();
        }

        private void Paste(object sender, EventArgs e) {
            textBoxMain.Paste();
        }

        private void SelectAll(object sender, EventArgs e) {
            textBoxMain.SelectAll();
        }
        #endregion

        private void TextBoxChanged(object sender, EventArgs e) {
            Files.isSaved = false;
            AutoBrackets.AddBrackets(this);
            Highlighting.UpdateTextBox(this);
        }

        private void TextBoxVScroll(object sender, EventArgs e) {
            numberLabel.Location = new Point(0, LineNumbers.CalcLabelY(this));
            LineNumbers.UpdateNumberLabel(this);
        }

        private void TextBoxFontChanged(object sender, EventArgs e) {
            LineNumbers.UpdateNumberLabel(this);
            TextBoxVScroll(sender, e);
        }

        private void TextBoxResized(object sender, EventArgs e) {
            TextBoxVScroll(sender, e);
        }

        private void TextBoxKeyUp(object sender, KeyEventArgs e) {
            LineNumbers.UpdateNumberLabel(this);
        }

        private void Exit(object sender, FormClosingEventArgs e) {
            Files.Exit();
        }

        private void DarkMode(object sender, EventArgs e) {
            Customizing.DarkMode(this);
        }

        private void Minimize(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }
    }
}