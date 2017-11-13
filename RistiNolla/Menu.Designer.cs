namespace RistiNolla
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVsKaveri = new System.Windows.Forms.Button();
            this.btnKauppa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPisteet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // btnVsKaveri
            // 
            this.btnVsKaveri.Location = new System.Drawing.Point(78, 140);
            this.btnVsKaveri.Name = "btnVsKaveri";
            this.btnVsKaveri.Size = new System.Drawing.Size(75, 35);
            this.btnVsKaveri.TabIndex = 2;
            this.btnVsKaveri.Text = "Vs Kaveri";
            this.btnVsKaveri.UseVisualStyleBackColor = true;
            this.btnVsKaveri.Click += new System.EventHandler(this.btnVsKaveri_Click);
            // 
            // btnKauppa
            // 
            this.btnKauppa.Location = new System.Drawing.Point(78, 181);
            this.btnKauppa.Name = "btnKauppa";
            this.btnKauppa.Size = new System.Drawing.Size(75, 35);
            this.btnKauppa.TabIndex = 3;
            this.btnKauppa.Text = "Kauppa";
            this.btnKauppa.UseVisualStyleBackColor = true;
            this.btnKauppa.Click += new System.EventHandler(this.btnKauppa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Vs Kone";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pisteet:";
            // 
            // lblPisteet
            // 
            this.lblPisteet.AutoSize = true;
            this.lblPisteet.Location = new System.Drawing.Point(196, 55);
            this.lblPisteet.Name = "lblPisteet";
            this.lblPisteet.Size = new System.Drawing.Size(13, 13);
            this.lblPisteet.TabIndex = 6;
            this.lblPisteet.Text = "0";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 272);
            this.Controls.Add(this.lblPisteet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKauppa);
            this.Controls.Add(this.btnVsKaveri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ristinolla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVsKaveri;
        public System.Windows.Forms.Button btnKauppa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblPisteet;
    }
}