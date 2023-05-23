namespace PaintProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.renk = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cizgi = new System.Windows.Forms.Button();
            this.btn_renk = new System.Windows.Forms.Button();
            this.btn_boya = new System.Windows.Forms.Button();
            this.btn_kalem = new System.Windows.Forms.Button();
            this.btn_silgi = new System.Windows.Forms.Button();
            this.btn_daire = new System.Windows.Forms.Button();
            this.btn_kare = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.renk);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 125);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PaintProje.Properties.Resources.color_palette;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // renk
            // 
            this.renk.BackColor = System.Drawing.Color.White;
            this.renk.Location = new System.Drawing.Point(248, 35);
            this.renk.Name = "renk";
            this.renk.Size = new System.Drawing.Size(43, 42);
            this.renk.TabIndex = 3;
            this.renk.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btn_cizgi);
            this.panel3.Controls.Add(this.btn_renk);
            this.panel3.Controls.Add(this.btn_boya);
            this.panel3.Controls.Add(this.btn_kalem);
            this.panel3.Controls.Add(this.btn_silgi);
            this.panel3.Controls.Add(this.btn_daire);
            this.panel3.Controls.Add(this.btn_kare);
            this.panel3.Location = new System.Drawing.Point(297, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 82);
            this.panel3.TabIndex = 5;
            // 
            // btn_cizgi
            // 
            this.btn_cizgi.BackColor = System.Drawing.Color.Gray;
            this.btn_cizgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_cizgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cizgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cizgi.ForeColor = System.Drawing.Color.White;
            this.btn_cizgi.Image = global::PaintProje.Properties.Resources.line;
            this.btn_cizgi.Location = new System.Drawing.Point(491, 5);
            this.btn_cizgi.Name = "btn_cizgi";
            this.btn_cizgi.Size = new System.Drawing.Size(74, 68);
            this.btn_cizgi.TabIndex = 4;
            this.btn_cizgi.Text = "DAİRE";
            this.btn_cizgi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cizgi.UseVisualStyleBackColor = false;
            // 
            // btn_renk
            // 
            this.btn_renk.BackColor = System.Drawing.Color.Gray;
            this.btn_renk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_renk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_renk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_renk.ForeColor = System.Drawing.Color.White;
            this.btn_renk.Image = global::PaintProje.Properties.Resources.color;
            this.btn_renk.Location = new System.Drawing.Point(11, 5);
            this.btn_renk.Name = "btn_renk";
            this.btn_renk.Size = new System.Drawing.Size(74, 68);
            this.btn_renk.TabIndex = 4;
            this.btn_renk.Text = "RENK";
            this.btn_renk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_renk.UseVisualStyleBackColor = false;
            // 
            // btn_boya
            // 
            this.btn_boya.BackColor = System.Drawing.Color.Gray;
            this.btn_boya.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_boya.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_boya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_boya.ForeColor = System.Drawing.Color.White;
            this.btn_boya.Image = global::PaintProje.Properties.Resources.bucket;
            this.btn_boya.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_boya.Location = new System.Drawing.Point(91, 5);
            this.btn_boya.Name = "btn_boya";
            this.btn_boya.Size = new System.Drawing.Size(74, 68);
            this.btn_boya.TabIndex = 4;
            this.btn_boya.Text = "BOYA";
            this.btn_boya.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_boya.UseVisualStyleBackColor = false;
            // 
            // btn_kalem
            // 
            this.btn_kalem.BackColor = System.Drawing.Color.Gray;
            this.btn_kalem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_kalem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_kalem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kalem.ForeColor = System.Drawing.Color.White;
            this.btn_kalem.Image = global::PaintProje.Properties.Resources.pencil;
            this.btn_kalem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kalem.Location = new System.Drawing.Point(171, 5);
            this.btn_kalem.Name = "btn_kalem";
            this.btn_kalem.Size = new System.Drawing.Size(74, 68);
            this.btn_kalem.TabIndex = 4;
            this.btn_kalem.Text = "KALEM";
            this.btn_kalem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kalem.UseVisualStyleBackColor = false;
            this.btn_kalem.Click += new System.EventHandler(this.btn_kalem_Click);
            // 
            // btn_silgi
            // 
            this.btn_silgi.BackColor = System.Drawing.Color.Gray;
            this.btn_silgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_silgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_silgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_silgi.ForeColor = System.Drawing.Color.White;
            this.btn_silgi.Image = global::PaintProje.Properties.Resources.eraser;
            this.btn_silgi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_silgi.Location = new System.Drawing.Point(251, 5);
            this.btn_silgi.Name = "btn_silgi";
            this.btn_silgi.Size = new System.Drawing.Size(74, 68);
            this.btn_silgi.TabIndex = 4;
            this.btn_silgi.Text = "SİLGİ";
            this.btn_silgi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_silgi.UseVisualStyleBackColor = false;
            this.btn_silgi.Click += new System.EventHandler(this.btn_silgi_Click);
            // 
            // btn_daire
            // 
            this.btn_daire.BackColor = System.Drawing.Color.Gray;
            this.btn_daire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_daire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_daire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_daire.ForeColor = System.Drawing.Color.White;
            this.btn_daire.Image = global::PaintProje.Properties.Resources.circle;
            this.btn_daire.Location = new System.Drawing.Point(331, 5);
            this.btn_daire.Name = "btn_daire";
            this.btn_daire.Size = new System.Drawing.Size(74, 68);
            this.btn_daire.TabIndex = 4;
            this.btn_daire.Text = "DAİRE";
            this.btn_daire.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_daire.UseVisualStyleBackColor = false;
            // 
            // btn_kare
            // 
            this.btn_kare.BackColor = System.Drawing.Color.Gray;
            this.btn_kare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_kare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_kare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kare.ForeColor = System.Drawing.Color.White;
            this.btn_kare.Image = global::PaintProje.Properties.Resources.rectangle;
            this.btn_kare.Location = new System.Drawing.Point(411, 5);
            this.btn_kare.Name = "btn_kare";
            this.btn_kare.Size = new System.Drawing.Size(74, 68);
            this.btn_kare.TabIndex = 4;
            this.btn_kare.Text = "KARE";
            this.btn_kare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kare.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 32);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(886, 509);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_renk;
        private Button renk;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button btn_cizgi;
        private Button btn_boya;
        private Button btn_kalem;
        private Button btn_silgi;
        private Button btn_daire;
        private Button btn_kare;
    }
}