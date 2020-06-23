namespace Content_Management_System__CMS_
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.NextPointBtn = new System.Windows.Forms.Button();
            this.EndBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.InfoText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InfoTitle = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CountTasks = new System.Windows.Forms.NumericUpDown();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numTarget = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.AddDescObj = new System.Windows.Forms.Button();
            this.AddTargetBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TitleTask = new System.Windows.Forms.TextBox();
            this.TypeTask = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DescTask = new System.Windows.Forms.TextBox();
            this.curTask = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.AutoSize = true;
            this.MainGroup.Controls.Add(this.NextPointBtn);
            this.MainGroup.Controls.Add(this.EndBtn);
            this.MainGroup.Controls.Add(this.label6);
            this.MainGroup.Controls.Add(this.InfoText);
            this.MainGroup.Controls.Add(this.label5);
            this.MainGroup.Controls.Add(this.InfoTitle);
            this.MainGroup.Controls.Add(this.StartBtn);
            this.MainGroup.Controls.Add(this.label1);
            this.MainGroup.Controls.Add(this.CountTasks);
            this.MainGroup.Location = new System.Drawing.Point(3, 3);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Size = new System.Drawing.Size(496, 228);
            this.MainGroup.TabIndex = 2;
            this.MainGroup.TabStop = false;
            this.MainGroup.Text = "Task";
            // 
            // NextPointBtn
            // 
            this.NextPointBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NextPointBtn.Location = new System.Drawing.Point(250, 155);
            this.NextPointBtn.Name = "NextPointBtn";
            this.NextPointBtn.Size = new System.Drawing.Size(94, 54);
            this.NextPointBtn.TabIndex = 9;
            this.NextPointBtn.Text = "Следующая точка";
            this.NextPointBtn.UseVisualStyleBackColor = true;
            this.NextPointBtn.Click += new System.EventHandler(this.NextPointBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.EndBtn.Location = new System.Drawing.Point(350, 155);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(139, 54);
            this.EndBtn.TabIndex = 8;
            this.EndBtn.Text = "Конец";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Visible = false;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(12, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Информация";
            // 
            // InfoText
            // 
            this.InfoText.Location = new System.Drawing.Point(12, 59);
            this.InfoText.Multiline = true;
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(225, 150);
            this.InfoText.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(240, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Заголовок";
            // 
            // InfoTitle
            // 
            this.InfoTitle.Location = new System.Drawing.Point(243, 59);
            this.InfoTitle.Name = "InfoTitle";
            this.InfoTitle.Size = new System.Drawing.Size(165, 20);
            this.InfoTitle.TabIndex = 4;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(415, 13);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Старт";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество задач";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CountTasks
            // 
            this.CountTasks.Location = new System.Drawing.Point(144, 16);
            this.CountTasks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountTasks.Name = "CountTasks";
            this.CountTasks.Size = new System.Drawing.Size(120, 20);
            this.CountTasks.TabIndex = 2;
            this.CountTasks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.MainGroup);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Size = new System.Drawing.Size(505, 465);
            this.splitContainer.SplitterDistance = 230;
            this.splitContainer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numTarget);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.AddDescObj);
            this.panel1.Controls.Add(this.AddTargetBtn);
            this.panel1.Controls.Add(this.NextBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TitleTask);
            this.panel1.Controls.Add(this.TypeTask);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DescTask);
            this.panel1.Controls.Add(this.curTask);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 223);
            this.panel1.TabIndex = 0;
            // 
            // numTarget
            // 
            this.numTarget.Location = new System.Drawing.Point(246, 82);
            this.numTarget.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTarget.Name = "numTarget";
            this.numTarget.Size = new System.Drawing.Size(193, 20);
            this.numTarget.TabIndex = 14;
            this.numTarget.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(247, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Количество целей";
            // 
            // AddDescObj
            // 
            this.AddDescObj.Enabled = false;
            this.AddDescObj.Location = new System.Drawing.Point(246, 152);
            this.AddDescObj.Name = "AddDescObj";
            this.AddDescObj.Size = new System.Drawing.Size(158, 23);
            this.AddDescObj.TabIndex = 12;
            this.AddDescObj.Text = "Добавить описание целей";
            this.AddDescObj.UseVisualStyleBackColor = true;
            this.AddDescObj.Click += new System.EventHandler(this.AddDescObj_Click);
            // 
            // AddTargetBtn
            // 
            this.AddTargetBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddTargetBtn.Location = new System.Drawing.Point(246, 125);
            this.AddTargetBtn.Name = "AddTargetBtn";
            this.AddTargetBtn.Size = new System.Drawing.Size(100, 23);
            this.AddTargetBtn.TabIndex = 11;
            this.AddTargetBtn.Text = "Добавить цели";
            this.AddTargetBtn.UseVisualStyleBackColor = false;
            this.AddTargetBtn.Click += new System.EventHandler(this.AddTargetBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(350, 189);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(139, 26);
            this.NextBtn.TabIndex = 10;
            this.NextBtn.Text = "Следующая задача";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(247, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Заголовок задачи";
            // 
            // TitleTask
            // 
            this.TitleTask.Location = new System.Drawing.Point(246, 43);
            this.TitleTask.Name = "TitleTask";
            this.TitleTask.Size = new System.Drawing.Size(193, 20);
            this.TitleTask.TabIndex = 6;
            // 
            // TypeTask
            // 
            this.TypeTask.FormattingEnabled = true;
            this.TypeTask.Items.AddRange(new object[] {
            "Find",
            "MultiFind",
            "Tour"});
            this.TypeTask.Location = new System.Drawing.Point(9, 152);
            this.TypeTask.Name = "TypeTask";
            this.TypeTask.Size = new System.Drawing.Size(228, 21);
            this.TypeTask.TabIndex = 5;
            this.TypeTask.SelectedIndexChanged += new System.EventHandler(this.TypeTask_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип задачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(9, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Описание задачи";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DescTask
            // 
            this.DescTask.Location = new System.Drawing.Point(8, 43);
            this.DescTask.Multiline = true;
            this.DescTask.Name = "DescTask";
            this.DescTask.Size = new System.Drawing.Size(232, 81);
            this.DescTask.TabIndex = 2;
            // 
            // curTask
            // 
            this.curTask.AutoSize = true;
            this.curTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.curTask.Location = new System.Drawing.Point(87, 6);
            this.curTask.Name = "curTask";
            this.curTask.Size = new System.Drawing.Size(17, 17);
            this.curTask.TabIndex = 1;
            this.curTask.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Задача № ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(505, 465);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountTasks)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CountTasks;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescTask;
        private System.Windows.Forms.Label curTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InfoText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InfoTitle;
        private System.Windows.Forms.ComboBox TypeTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TitleTask;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Button AddDescObj;
        private System.Windows.Forms.Button AddTargetBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button NextPointBtn;
        private System.Windows.Forms.NumericUpDown numTarget;
        private System.Windows.Forms.Label label9;
    }
}

