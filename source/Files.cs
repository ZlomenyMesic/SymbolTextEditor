using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighQualityTextEditor {
    internal static class Files {
        public static string? currentFile = null;
        public static bool isSaved = true;
        public static bool isClosing = false;

        public static void Exit() {
            if (!isClosing || isSaved || MessageBox.Show("Are you sure you want to exit? All unsaved progress will be lost", "HQ Text Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                isClosing = true;
                Application.Exit();
            } else return;
        }

        public static void Open(Form1 form1) {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Text files (.txt)|*.txt";
            o.Title = "Select a file";

            if (o.ShowDialog() == DialogResult.OK) {
                if (!isSaved && MessageBox.Show("Are you sure you want to open the file? All unsaved progress will be lost", "HQ Text Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    return;

                currentFile = o.FileName;
                form1.label1.Text = $"HQ Text Editor - {o.FileName}";
                using (StreamReader sr = new StreamReader(o.FileName)) {
                    form1.textBoxMain.Text = sr.ReadToEnd();
                    sr.Close();
                    isSaved = true;
                }
            }
        }

        public static void Save(Form1 form1) {
            if (currentFile != null) {
                using StreamWriter sw = new StreamWriter(currentFile);
                sw.Write(form1.textBoxMain.Text);
                sw.Close();
                isSaved = true;
            } else SaveAs(form1);
        } 

        public static void SaveAs(Form1 form1) {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Text files (.txt)|*.txt";
            s.Title = "Select the destination";

            if (s.ShowDialog() == DialogResult.OK) {
                currentFile = s.FileName;
                form1.label1.Text = $"HQ Text Editor - {s.FileName}";
                using (StreamWriter sw = new StreamWriter(s.FileName)) {
                    sw.Write(form1.textBoxMain.Text);
                    sw.Close();
                    isSaved = true;
                }
            }
        }

        public static void New(Form1 form1) {
            if (isSaved || MessageBox.Show("Are you sure you want to open a new file? All unsaved progress will be lost", "HQ Text Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                form1.textBoxMain.Clear();
                isSaved = true;
            }
        }
    }
}
