using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Content_Management_System__CMS_
{
    public partial class AddDescObj : Form
    {
        string[] listDesc;
        public int countTarget;
        int currentTarget = 0;
        public MainForm mf;
        public AddDescObj(int countT)
        {
            InitializeComponent();
            this.Text = "Текущая цель - " + (currentTarget + 1).ToString();
            this.FormClosing += new FormClosingEventHandler(AddTarget_FormClosing);
            countTarget = countT;
            listDesc = new string[countTarget];
            NumTarget.Text = (currentTarget + 1).ToString();
        }


        void AddTarget_FormClosing(object sender, FormClosingEventArgs e)
        {
           mf.listDescTarget = listDesc;
        }

        private void NextTargetBtn_Click(object sender, EventArgs e)
        {
            if (DescBox.Text == string.Empty)
            {
                MessageBox.Show("Error", "Path is empty", MessageBoxButtons.OK);
                return;
            }
            else
            {
                currentTarget++;
                DescBox.Text = string.Empty;
                NumTarget.Text = (currentTarget + 1).ToString();
                this.Text = "Текущая цель - " + (currentTarget + 1).ToString();
                if (currentTarget >= countTarget)
                    this.Close();
            }
        }
    }
}
