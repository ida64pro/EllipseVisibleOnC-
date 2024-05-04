namespace Lab
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sNum = new System.Windows.Forms.TextBox();
            this.tNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ost = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.redEllipse = new System.Windows.Forms.PictureBox();
            this.blueEllipse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueEllipse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первое число:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(231, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Второе число:";
            // 
            // sNum
            // 
            this.sNum.Location = new System.Drawing.Point(16, 55);
            this.sNum.Name = "sNum";
            this.sNum.Size = new System.Drawing.Size(149, 20);
            this.sNum.TabIndex = 2;
            // 
            // tNum
            // 
            this.tNum.Location = new System.Drawing.Point(233, 55);
            this.tNum.Name = "tNum";
            this.tNum.Size = new System.Drawing.Size(149, 20);
            this.tNum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(186, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // ost
            // 
            this.ost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ost.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ost.Location = new System.Drawing.Point(16, 81);
            this.ost.Name = "ost";
            this.ost.Size = new System.Drawing.Size(366, 29);
            this.ost.TabIndex = 5;
            this.ost.Text = "Обчисляти";
            this.ost.UseVisualStyleBackColor = true;
            this.ost.Click += new System.EventHandler(this.ost_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-422, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // redEllipse
            // 
            this.redEllipse.Image = ((System.Drawing.Image)(resources.GetObject("redEllipse.Image")));
            this.redEllipse.InitialImage = ((System.Drawing.Image)(resources.GetObject("redEllipse.InitialImage")));
            this.redEllipse.Location = new System.Drawing.Point(84, 116);
            this.redEllipse.Name = "redEllipse";
            this.redEllipse.Size = new System.Drawing.Size(251, 140);
            this.redEllipse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redEllipse.TabIndex = 7;
            this.redEllipse.TabStop = false;
            this.redEllipse.Visible = false;
            // 
            // blueEllipse
            // 
            this.blueEllipse.Image = ((System.Drawing.Image)(resources.GetObject("blueEllipse.Image")));
            this.blueEllipse.InitialImage = ((System.Drawing.Image)(resources.GetObject("blueEllipse.InitialImage")));
            this.blueEllipse.Location = new System.Drawing.Point(84, 116);
            this.blueEllipse.Name = "blueEllipse";
            this.blueEllipse.Size = new System.Drawing.Size(251, 140);
            this.blueEllipse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueEllipse.TabIndex = 8;
            this.blueEllipse.TabStop = false;
            this.blueEllipse.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 293);
            this.Controls.Add(this.blueEllipse);
            this.Controls.Add(this.redEllipse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tNum);
            this.Controls.Add(this.sNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "General";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueEllipse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sNum;
        private System.Windows.Forms.TextBox tNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox redEllipse;
        private System.Windows.Forms.PictureBox blueEllipse;
    }
}

