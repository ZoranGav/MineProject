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
using System.Diagnostics;

namespace FileSearch
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        this.itmesListBox.MouseDoubleClick += new MouseEventHandler(itmesListBox_MouseDoubleClick);
        }

        public void directoryLocationBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fBD = new FolderBrowserDialog();
            if (fBD.ShowDialog() == DialogResult.OK)
            {
                directoryLocationBox.Text = fBD.SelectedPath;
                
            }
            

         }
        
        private void searchBtn_Click(object sender, EventArgs e)
        {
            itmesListBox.Items.Clear();

            string word = searchTextBox.Text;

            string dirLocation = directoryLocationBox.Text;

            int numbOfRep = 0;
            
            

            if (directoryLocationBox.Text == "")
            {
                MessageBox.Show("You must choose the directory!");
                directoryLocationBox.Focus();

            }
            else
            {
                if (searchTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the word you want to be found!");
                    searchTextBox.Focus();
                }
                else
                {
                    string[] files = Directory.GetFiles(dirLocation, "*", SearchOption.AllDirectories);

                    foreach (string path in files)
                    {

                        using (StreamReader sR = File.OpenText(path))
                        {
                            string txtFile = sR.ReadToEnd();
                            string[] intoArray = txtFile.Split(' ', ',');

                            for (int i = 0; i < intoArray.Length; i++)
                            {

                                if (intoArray[i] == word)
                                {
                                    numbOfRep++;
                                }
                                
                                
                                
                            }

                            sR.Close();
                            if (numbOfRep != 0)
                            {
                                string putanja = Path.GetFileName(path);
                                itmesListBox.Items.Add(putanja + ", " + "number of repetitions: " + numbOfRep);
                                 
                                numbOfRep -= numbOfRep;
                            }


                            int numbOfFiles = files.Length;
                            label2.Text = "Number of files checked: " + numbOfFiles; 
                        }
                            
                    }
                }
            }
        }


        public void itmesListBox_MouseDoubleClick(object sender, MouseEventArgs e)

        {

            int index = this.itmesListBox.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)

            {
                string fileName = itmesListBox.SelectedItem.ToString();
                string pathString = directoryLocationBox.Text +"/"+ fileName.Split(',')[0];
                Process.Start("notepad.exe", pathString);

                //do your stuff here

            }

        }
    }
}
