using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace scriptEditorForYGOPRO2
{
    public partial class Form1 : Form
    {
        FileInfo[] Files;
        public Form1()
        {
            InitializeComponent();
        }

        //Odczyt do richboxa z pliku
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            FileInfo file = (FileInfo)this.listBox1.SelectedItem;
            richTextBox1.Text = File.ReadAllText(file.FullName);
        }

        //Zapis z richboxa do pliku
        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo file = (FileInfo)listBox1.SelectedItem;
            File.WriteAllText(file.FullName, richTextBox1.Text);
        }
        //usuniecie niepotrzebnej inicjacji zmiennych
        private void button4_Click(object sender, EventArgs e)
        {

         richTextBox1.Text= richTextBox1.Text.Replace("local s,id=GetID()", "");
        }
        //nadpisanie id
        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo file = (FileInfo)listBox1.SelectedItem;
            string pattern = @"(\W)id";
            string fileID = Path.GetFileNameWithoutExtension(file.Name).Replace("c","");
            string replacement = "$1 " + fileID;
            richTextBox1.Text = Regex.Replace(richTextBox1.Text, pattern, replacement);

        }
        //nadpisanie s.
        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo file = (FileInfo)listBox1.SelectedItem;
            string fileID = Path.GetFileNameWithoutExtension(file.Name);
            richTextBox1.Text=richTextBox1.Text.Replace("s.",fileID+".");
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            string path;
            DialogResult result =folderBrowserDialog1.ShowDialog();
            if(result== DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                return;
            }
           
            label1.Text = path;
            DirectoryInfo directory = new DirectoryInfo(path);
            Files = directory.GetFiles("*.lua");
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Files);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            backgroundWorkerDoEverything.RunWorkerAsync();
        }

        private void backgroundWorkerDoEverything_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (FileInfo file in listBox1.Items)
            {
                richTextBox1.Invoke(new Action(()=>{
                    richTextBox1.Text = File.ReadAllText(file.FullName);
                    richTextBox1.Text = richTextBox1.Text.Replace("local s,id=GetID()", "");
                    string pattern = @"(\W)id";
                    string fileID = Path.GetFileNameWithoutExtension(file.Name).Replace("c", "");
                    string replacement = "$1 " + fileID;
                    richTextBox1.Text = Regex.Replace(richTextBox1.Text, pattern, replacement);
                    richTextBox1.Text = richTextBox1.Text.Replace("s.", "c"+fileID + ".");
                    File.WriteAllText(file.FullName, richTextBox1.Text);
                }));

            }
        }
    }
}
