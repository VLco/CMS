namespace Content_Management_System__CMS_
{
    partial class AddTarget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.NextTargetBtn = new System.Windows.Forms.Button();
            this.NumTarget = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NextTargetBtn);
            this.panel1.Controls.Add(this.NumTarget);
            this.panel1.Controls.Add(this.openFileDialog);
            this.panel1.Controls.Add(this.path);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 78);
            this.panel1.TabIndex = 0;
            // 
            // NextTargetBtn
            // 
            this.NextTargetBtn.Location = new System.Drawing.Point(184, 49);
            this.NextTargetBtn.Name = "NextTargetBtn";
            this.NextTargetBtn.Size = new System.Drawing.Size(110, 23);
            this.NextTargetBtn.TabIndex = 4;
            this.NextTargetBtn.Text = "Следующая цель";
            this.NextTargetBtn.UseVisualStyleBackColor = true;
            this.NextTargetBtn.Click += new System.EventHandler(this.NextTargetBtn_Click);
            // 
            // NumTarget
            // 
            this.NumTarget.AutoSize = true;
            this.NumTarget.Location = new System.Drawing.Point(53, 6);
            this.NumTarget.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.NumTarget.Name = "NumTarget";
            this.NumTarget.Size = new System.Drawing.Size(13, 13);
            this.NumTarget.TabIndex = 3;
            this.NumTarget.Text = "0";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Location = new System.Drawing.Point(146, 20);
            this.openFileDialog.Name = "openFileDialog";
            this.openFileDialog.Size = new System.Drawing.Size(75, 23);
            this.openFileDialog.TabIndex = 2;
            this.openFileDialog.Text = "Обзор";
            this.openFileDialog.UseVisualStyleBackColor = true;
            this.openFileDialog.Click += new System.EventHandler(this.openFileDialog_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(3, 22);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(137, 20);
            this.path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задача - ";
            // 
            // AddTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 102);
            this.Controls.Add(this.panel1);
            this.Name = "AddTarget";
            this.Text = "AddTarget";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openFileDialog;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label NumTarget;
        private System.Windows.Forms.Button NextTargetBtn;
    }
}