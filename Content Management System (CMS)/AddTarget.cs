using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Content_Management_System__CMS_
{
    public partial class AddTarget : Form
    {
        string[] listPath;
        public int countTarget;
        int currentTarget = 0;
        public MainForm mf;
        public AddTarget(int countT)
        {
            InitializeComponent();
            this.Text = "Текущая цель - " + (currentTarget + 1).ToString();
            this.FormClosing += new FormClosingEventHandler(AddTarget_FormClosing);
            countTarget = countT;
            listPath = new string[countTarget];
            NumTarget.Text = (currentTarget + 1).ToString();


        }

        private void openFileDialog_Click(object sender, EventArgs e)
        {
            var fileOpenResult = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    path.Text = filePath;
                    Console.WriteLine(listPath.Length);
                    listPath[currentTarget] = filePath;
                    if(filePath != "")
                    {
                        fileOpenResult = "Ok";
                    }  
                    else
                    {
                        fileOpenResult = "No";
                    }
                }
                
            }

            MessageBox.Show(fileOpenResult, "Result open file: " + filePath, MessageBoxButtons.OK);
        }

        private void NextTargetBtn_Click(object sender, EventArgs e)
        {
            if(path.Text == string.Empty)
            {
                MessageBox.Show("Error", "Path is empty", MessageBoxButtons.OK);
                return;
            }
            else
            {
                currentTarget++;
                path.Text = string.Empty;
                NumTarget.Text = (currentTarget + 1).ToString();
                this.Text = "Текущая цель - " + (currentTarget + 1).ToString();
                if (currentTarget >= countTarget)
                    this.Close();
            }
        }

        void AddTarget_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.listTarget[mf.currentPoint][mf.currentTask] = listPath;
        }
    }
}
