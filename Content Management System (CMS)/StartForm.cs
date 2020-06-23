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
    public partial class StartForm : Form
    {

        public int countPoints { get; set; }
        public string pathSave { get; set; }
        public StartForm()
        {
            InitializeComponent();
            countPoints = (int)CountPoints.Value;
        }

        private void CountPoints_ValueChanged(object sender, EventArgs e)
        {
            countPoints = (int)CountPoints.Value;

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(countPoints, pathSave);
            mf.Show();
            mf.Text = "Текущая точка - 1 из " + countPoints.ToString();
            mf.Activate();
            this.Hide();
            
        }

    }
}
