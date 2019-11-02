namespace XLA_Project08
{
    partial class Form1
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
            this.pictureBox_hinhgoc = new System.Windows.Forms.PictureBox();
            this.label_hinhgoc = new System.Windows.Forms.Label();
            this.label_edge = new System.Windows.Forms.Label();
            this.pictureBox_edge = new System.Windows.Forms.PictureBox();
            this.button_sobel = new System.Windows.Forms.Button();
            this.button_prewitt = new System.Windows.Forms.Button();
            this.label_nguong = new System.Windows.Forms.Label();
            this.textBox_nguong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hinhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_edge)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_hinhgoc
            // 
            this.pictureBox_hinhgoc.Location = new System.Drawing.Point(12, 42);
            this.pictureBox_hinhgoc.Name = "pictureBox_hinhgoc";
            this.pictureBox_hinhgoc.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_hinhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_hinhgoc.TabIndex = 0;
            this.pictureBox_hinhgoc.TabStop = false;
            // 
            // label_hinhgoc
            // 
            this.label_hinhgoc.AutoSize = true;
            this.label_hinhgoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hinhgoc.Location = new System.Drawing.Point(201, 18);
            this.label_hinhgoc.Name = "label_hinhgoc";
            this.label_hinhgoc.Size = new System.Drawing.Size(124, 21);
            this.label_hinhgoc.TabIndex = 1;
            this.label_hinhgoc.Text = "Hình RGB gốc";
            // 
            // label_edge
            // 
            this.label_edge.AutoSize = true;
            this.label_edge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_edge.Location = new System.Drawing.Point(979, 18);
            this.label_edge.Name = "label_edge";
            this.label_edge.Size = new System.Drawing.Size(187, 21);
            this.label_edge.TabIndex = 3;
            this.label_edge.Text = "Hình đã nhận dạng biên";
            // 
            // pictureBox_edge
            // 
            this.pictureBox_edge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_edge.Location = new System.Drawing.Point(820, 42);
            this.pictureBox_edge.Name = "pictureBox_edge";
            this.pictureBox_edge.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_edge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_edge.TabIndex = 2;
            this.pictureBox_edge.TabStop = false;
            // 
            // button_sobel
            // 
            this.button_sobel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_sobel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sobel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sobel.ForeColor = System.Drawing.Color.DarkRed;
            this.button_sobel.Location = new System.Drawing.Point(603, 193);
            this.button_sobel.Name = "button_sobel";
            this.button_sobel.Size = new System.Drawing.Size(138, 85);
            this.button_sobel.TabIndex = 5;
            this.button_sobel.Text = "Sobel\'s mask";
            this.button_sobel.UseVisualStyleBackColor = false;
            this.button_sobel.Click += new System.EventHandler(this.button_sobel_Click);
            // 
            // button_prewitt
            // 
            this.button_prewitt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_prewitt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_prewitt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_prewitt.ForeColor = System.Drawing.Color.DarkRed;
            this.button_prewitt.Location = new System.Drawing.Point(603, 284);
            this.button_prewitt.Name = "button_prewitt";
            this.button_prewitt.Size = new System.Drawing.Size(138, 85);
            this.button_prewitt.TabIndex = 6;
            this.button_prewitt.Text = "Prewitt\'s mask";
            this.button_prewitt.UseVisualStyleBackColor = false;
            this.button_prewitt.Click += new System.EventHandler(this.button_prewitt_Click);
            // 
            // label_nguong
            // 
            this.label_nguong.AutoSize = true;
            this.label_nguong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nguong.Location = new System.Drawing.Point(581, 148);
            this.label_nguong.Name = "label_nguong";
            this.label_nguong.Size = new System.Drawing.Size(74, 21);
            this.label_nguong.TabIndex = 7;
            this.label_nguong.Text = "Ngưỡng:";
            // 
            // textBox_nguong
            // 
            this.textBox_nguong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nguong.Location = new System.Drawing.Point(661, 145);
            this.textBox_nguong.Name = "textBox_nguong";
            this.textBox_nguong.Size = new System.Drawing.Size(99, 29);
            this.textBox_nguong.TabIndex = 4;
            this.textBox_nguong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 683);
            this.Controls.Add(this.label_nguong);
            this.Controls.Add(this.button_prewitt);
            this.Controls.Add(this.button_sobel);
            this.Controls.Add(this.textBox_nguong);
            this.Controls.Add(this.label_edge);
            this.Controls.Add(this.pictureBox_edge);
            this.Controls.Add(this.label_hinhgoc);
            this.Controls.Add(this.pictureBox_hinhgoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hinhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_edge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_hinhgoc;
        private System.Windows.Forms.Label label_hinhgoc;
        private System.Windows.Forms.Label label_edge;
        private System.Windows.Forms.PictureBox pictureBox_edge;
        private System.Windows.Forms.Button button_sobel;
        private System.Windows.Forms.Button button_prewitt;
        private System.Windows.Forms.Label label_nguong;
        private System.Windows.Forms.TextBox textBox_nguong;
    }
}

