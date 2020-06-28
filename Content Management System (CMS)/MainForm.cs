using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Content_Management_System__CMS_
{
    public partial class MainForm : Form
    {
        int countPoints = 1;
        public int currentPoint = 0;
        ResForPoint[] resources;
        Task[] tasks;
        int countTasks;
        string infoText;
        string pathSave;
        string infoTitle;
        public int currentTask = 0;
        public string[][][] listTarget;
        public string[] listDescTarget;
        public MainForm(int cp, string path)
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Main_FormClosed);
            splitContainer.Panel2Collapsed = true;
            Size = new Size(Size.Width, 280);
            EndBtn.Visible = false;
            AddDescObj.Enabled = false;
            countPoints = cp;
            pathSave = path;
            NextPointBtn.Visible = false;
            TypeTask.SelectedIndex = 1;
            listTarget = new string[countPoints][][];
            resources = new ResForPoint[countPoints];
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            
            if(CountTasks.Value != 0 && InfoText.Text != "" && InfoTitle.Text != "")
            {
                splitContainer.Panel2Collapsed = false;
                Size = new Size(Size.Width, 504);
                countTasks = (int)CountTasks.Value;
                infoText = InfoText.Text;
                infoTitle = InfoTitle.Text;
                tasks = new Task[countTasks];
                StartBtn.Enabled = false;
                curTask.Text = (currentTask+1).ToString();
                listTarget[currentPoint] = new string[countTasks][];
                NextBtn.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Error", MessageBoxButtons.OK);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TypeTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeTask.SelectedItem.ToString() == "Tour") 
            {
                numTarget.Enabled = true;
                AddDescObj.Enabled = true;
            }
            else if(TypeTask.SelectedItem.ToString() == "MultiFind")
            {
                numTarget.Enabled = true;
                AddDescObj.Enabled = false;
            }
            else
            {
                numTarget.Enabled = false;
                AddDescObj.Enabled = false;

            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {   

            if (DescTask.Text != "" && TitleTask.Text != "" && TypeTask.SelectedItem.ToString() != "" &&
                currentTask <= countTasks && listTarget[currentPoint][currentTask].Length != 0)
            {
                typeTask type = typeTask.Find;
                if(TypeTask.SelectedItem.ToString() == "Find")
                {
                    type = typeTask.Find;
                }
                else if (TypeTask.SelectedItem.ToString() == "MultiFind")
                {
                    type = typeTask.MultiFind;
                }
                else if (TypeTask.SelectedItem.ToString() == "Tour")
                {
                    type = typeTask.Tour;
                }
                if (typeTask.Tour == type && listDescTarget.Length == (int)numTarget.Value)
                {
                    tasks[currentTask] = new Task(type, DescTask.Text, TitleTask.Text, listDescTarget);
                }
                else if(typeTask.Tour != type)
                {
                    tasks[currentTask] = new Task(type, DescTask.Text, TitleTask.Text);

                }
                else
                {
                    MessageBox.Show("Error", "Count descTarget is not equal count target", MessageBoxButtons.OK);
                }
                currentTask++;
                curTask.Text = (currentTask+1).ToString();
                
                if (currentTask >= countTasks)
                {
                    NextBtn.Enabled = false;
                    NextPointBtn.Visible = true;
                }


            }
            else
            {
                MessageBox.Show("Заполните все поля", "Error", MessageBoxButtons.OK);

            }
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {

            using (var folder = new FolderBrowserDialog())
            {
                if(folder.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(folder.SelectedPath+ "\\DataFile.xml", FileMode.OpenOrCreate))
                    {
                        XmlSerializer formatter = new XmlSerializer(typeof(ResForPoint[]));
                        try
                        {
                            formatter.Serialize(fs, resources);

                        }
                        catch (SerializationException exception)
                        {
                            Console.WriteLine("Failed to serialize. Reason: " + exception.Message);
                            throw;
                        }
                        finally
                        {
                            fs.Close();
                        }
                    }
                    using (FileStream fs = new FileStream(folder.SelectedPath + "\\DataFile.zip", FileMode.OpenOrCreate))
                    {
                        using (ZipArchive archive = new ZipArchive(fs, ZipArchiveMode.Update))
                        {
                            string typeTarget = string.Empty;
                            
                            ZipArchiveEntry datainfo;
                            if (archive.GetEntry("DataFile.xml") != null)
                                datainfo = archive.GetEntry("DataFile.xml");
                            else
                                datainfo = archive.CreateEntry("DataFile.xml");



                            using (var fileInArchive = datainfo.Open())
                            {
                                using (FileStream df = new FileStream(folder.SelectedPath + "\\DataFile.xml", FileMode.OpenOrCreate))
                                {
                                    df.CopyTo(fileInArchive);
                                }
                            }
                            File.Delete(folder.SelectedPath + "\\DataFile.xml");
                            

                            int indPoints = 0;
                            foreach (string[][] Point in listTarget)
                            {
                                int indTasks = 0;
                                foreach (string[] Task in Point)
                                {
                                    int indTargets = 0;
                                    foreach (string target in Task)
                                    {
                                        string[] typesImg = { "png", "jpg" };
                                        if (Array.Exists(typesImg, element => element == target.Split('.').Last()))
                                        {
                                            typeTarget = "Texture";
                                        }
                                        else
                                        {
                                            typeTarget = "Model";
                                        }
                                        string pathInArchive = "Point_" + indPoints.ToString() +
                                            "\\Task_" + indTasks.ToString() + "\\Target\\" + typeTarget + "_" +
                                            indTargets.ToString() + "." + target.Split('.').Last();

                                        ZipArchiveEntry entry;

                                        if (archive.GetEntry(pathInArchive) != null)
                                            entry = archive.GetEntry(pathInArchive);
                                        else
                                            entry = archive.CreateEntry(pathInArchive);

                                        using (var fileInArchive = entry.Open())
                                        {
                                            using (var file = new FileStream(target, FileMode.Open))
                                            {
                                                file.CopyTo(fileInArchive);
                                            }
                                        }
                                        indTargets++;
                                    }
                                    indTasks++;
                                }
                                indPoints++;
                            }
                        }
                    }

                }

            }
            MessageBox.Show("Datafile create!!!");
        }

        private void AddTargetBtn_Click(object sender, EventArgs e)
        {
            AddTarget addTarget = new AddTarget((int) numTarget.Value);
            addTarget.Show();
            addTarget.mf = this;
            
        }

        private void NextPointBtn_Click(object sender, EventArgs e)
        {
            resources[currentPoint] = new ResForPoint(countTasks, tasks, infoText, infoTitle);
            currentPoint++;
            StartBtn.Enabled = true;
            splitContainer.Panel2Collapsed = true;
            Size = new Size(Size.Width, 280); TypeTask.SelectedIndex = 1;
            InfoText.Text = string.Empty;
            InfoTitle.Text = string.Empty;
            if (currentPoint >= countPoints)
            {
                this.Text = "Завершите создание файла ресурсов";
                EndBtn.Visible = true;
                NextPointBtn.Visible = false;
                StartBtn.Enabled = false;
                InfoText.Enabled = false;
                InfoTitle.Enabled = false;
            }
            else
            {
                this.Text = "Текущая точка - " + (1+currentPoint).ToString() + " из " + countPoints.ToString();
                TypeTask.SelectedIndex = 1;
                DescTask.Text = string.Empty;
                TitleTask.Text = string.Empty;
                NextPointBtn.Visible = false;
                currentTask = 0;
                numTarget.Value = 1;
                CountTasks.Value = 1;
            }
        }
        void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddDescObj_Click(object sender, EventArgs e)
        {
            listDescTarget = new string[(int)numTarget.Value];
            AddDescObj addDesc = new AddDescObj((int)numTarget.Value);
            addDesc.Show();
            addDesc.mf = this;
        }
    }
    [Serializable]
    public class Task
    {
        public typeTask typeTask { get; set; }
        public string desc { get; set; }
        public string title { get; set; }

        public string[] descObj { get; set; } = null;

        public Task(typeTask _type, string _desc, string _title, string[] _descObj = null)
        {
            this.title = _title;
            this.typeTask = _type;
            this.desc = _desc;
            if (typeTask.Tour == _type)
            {
                this.descObj = _descObj;
            }        
        }

        public Task(typeTask _type, string _desc, string _title)
        {
            this.title = _title;
            this.typeTask = _type;
            this.desc = _desc;   
        }

        public Task() { }

    }


    [Serializable]
    public class ResForPoint
    {
        public int countTasks { get; set; }
        public Task[] tasks { get; set; }
        public string infoText { get; set; }
        public string infoTitle { get; set; }

        public ResForPoint(int countTasks,Task[] tasks, string infoText, string infoTitle)
        {
            this.countTasks = countTasks;
            this.tasks = tasks;
            this.infoText = infoText;
            this.infoTitle = infoTitle;
        }

        public ResForPoint() { }

    }



    public enum typeTask
    {
        Find = 1,
        MultiFind,
        Tour,

    }
}
