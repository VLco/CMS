namespace Content_Management_System__CMS_
{
    partial class StartForm
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
            this.labelCountPoint = new System.Windows.Forms.Label();
            this.CountPoints = new System.Windows.Forms.NumericUpDown();
            this.StartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CountPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCountPoint
            // 
            this.labelCountPoint.AutoSize = true;
            this.labelCountPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPoint.Location = new System.Drawing.Point(12, 9);
            this.labelCountPoint.Name = "labelCountPoint";
            this.labelCountPoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCountPoint.Size = new System.Drawing.Size(128, 17);
            this.labelCountPoint.TabIndex = 3;
            this.labelCountPoint.Text = "Количество точек";
            this.labelCountPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CountPoints
            // 
            this.CountPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountPoints.Location = new System.Drawing.Point(152, 9);
            this.CountPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountPoints.Name = "CountPoints";
            this.CountPoints.Size = new System.Drawing.Size(120, 20);
            this.CountPoints.TabIndex = 2;
            this.CountPoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountPoints.ValueChanged += new System.EventHandler(this.CountPoints_ValueChanged);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(174, 47);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(98, 23);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "OK";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 82);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.labelCountPoint);
            this.Controls.Add(this.CountPoints);
            this.MaximumSize = new System.Drawing.Size(300, 165);
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.CountPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountPoint;
        private System.Windows.Forms.NumericUpDown CountPoints;
        private System.Windows.Forms.Button StartBtn;
    }
}