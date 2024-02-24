using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace notepad
{
    public partial class Form1 : Form
    {
        private string _openFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void темнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.DimGray;
            menuStrip1.BackColor = Color.DarkGray;
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor= Color.Black;
            richTextBox1.BackColor = Color.White;
            menuStrip1.BackColor = Color.SeaShell;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog beautiful = new FontDialog();
            if (beautiful.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = beautiful.Font;
            }
        }

        private void времяИДатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now;
        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fdialog = new OpenFileDialog();
            Fdialog.Filter = "all (*.*) | *.* ";
            if (Fdialog.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.Text = File.ReadAllText(Fdialog.FileName);
                _openFile = Fdialog.FileName;
            }

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Sdialog = new SaveFileDialog();
            Sdialog.Filter = "all (*.*) | *.* ";
            if (Sdialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(Sdialog.FileName, richTextBox1.Text);
                _openFile = Sdialog.FileName;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                File.WriteAllText(_openFile, richTextBox1.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Не удалось сохранить");
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += Print;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document.Print();
            }
        }
        public void Print(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.DarkGray, 0, 0);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void создатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            _openFile = null;
        }

        private void РазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = richTextBox1.Font; 
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font; 
            }
        }

        private void увеличитьРазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size + 1);
        }

        private void уменьшитьРазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Size > 1)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size - 1);
            }
        }

        private void выделитьЖирнымToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                FontStyle currentStyle = richTextBox1.SelectionFont.Style;

                if (currentStyle == FontStyle.Bold)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, currentStyle ^ FontStyle.Bold);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, currentStyle | FontStyle.Bold);
                }
            }
        }

        private void выделитьКурсивомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                FontStyle currentStyle = richTextBox1.SelectionFont.Style;

                if (currentStyle == FontStyle.Italic)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, currentStyle ^ FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, currentStyle | FontStyle.Italic);
                }
            }
        }

        private void ЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void скопироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectedText = "";
            }
        }

        private void перевестиСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("\n");
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сведения (О программе) \n \n Приложение NotePad \n \n Разработано с помощью Visual Studio \n \n Сделала Богданова Елизавета, 09-322");
        }
    }
}
