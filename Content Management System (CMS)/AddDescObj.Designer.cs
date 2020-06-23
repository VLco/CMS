namespace Content_Management_System__CMS_
{
    partial class AddDescObj
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumTarget = new System.Windows.Forms.Label();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.NextTargetBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NextTargetBtn);
            this.panel1.Controls.Add(this.DescBox);
            this.panel1.Controls.Add(this.NumTarget);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 141);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Описание к цели №";
            // 
            // NumTarget
            // 
            this.NumTarget.AutoSize = true;
            this.NumTarget.Location = new System.Drawing.Point(116, 5);
            this.NumTarget.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.NumTarget.Name = "NumTarget";
            this.NumTarget.Size = new System.Drawing.Size(13, 13);
            this.NumTarget.TabIndex = 1;
            this.NumTarget.Text = "0";
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(6, 21);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(323, 84);
            this.DescBox.TabIndex = 2;
            // 
            // NextTargetBtn
            // 
            this.NextTargetBtn.Location = new System.Drawing.Point(200, 111);
            this.NextTargetBtn.Name = "NextTargetBtn";
            this.NextTargetBtn.Size = new System.Drawing.Size(120, 23);
            this.NextTargetBtn.TabIndex = 3;
            this.NextTargetBtn.Text = "Следующая цель";
            this.NextTargetBtn.UseVisualStyleBackColor = true;
            this.NextTargetBtn.Click += new System.EventHandler(this.NextTargetBtn_Click);
            // 
            // AddDescObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(357, 166);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(373, 205);
            this.Name = "AddDescObj";
            this.Text = "AddDescObj";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextTargetBtn;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.Label NumTarget;
    }
}