namespace RistiNolla
{
    partial class Nimet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPelaaja1Nimi = new System.Windows.Forms.TextBox();
            this.tbPelaaja2Nimi = new System.Windows.Forms.TextBox();
            this.btnAloita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelaaja1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelaaja2";
            // 
            // tbPelaaja1Nimi
            // 
            this.tbPelaaja1Nimi.Location = new System.Drawing.Point(18, 126);
            this.tbPelaaja1Nimi.Name = "tbPelaaja1Nimi";
            this.tbPelaaja1Nimi.Size = new System.Drawing.Size(100, 20);
            this.tbPelaaja1Nimi.TabIndex = 2;
            // 
            // tbPelaaja2Nimi
            // 
            this.tbPelaaja2Nimi.Location = new System.Drawing.Point(194, 126);
            this.tbPelaaja2Nimi.Name = "tbPelaaja2Nimi";
            this.tbPelaaja2Nimi.Size = new System.Drawing.Size(100, 20);
            this.tbPelaaja2Nimi.TabIndex = 3;
            // 
            // btnAloita
            // 
            this.btnAloita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAloita.Location = new System.Drawing.Point(100, 180);
            this.btnAloita.Name = "btnAloita";
            this.btnAloita.Size = new System.Drawing.Size(105, 54);
            this.btnAloita.TabIndex = 4;
            this.btnAloita.Text = "Aloita";
            this.btnAloita.UseVisualStyleBackColor = true;
            this.btnAloita.Click += new System.EventHandler(this.btnAloita_Click);
            // 
            // Nimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 272);
            this.Controls.Add(this.btnAloita);
            this.Controls.Add(this.tbPelaaja2Nimi);
            this.Controls.Add(this.tbPelaaja1Nimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nimet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nimet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPelaaja1Nimi;
        private System.Windows.Forms.TextBox tbPelaaja2Nimi;
        private System.Windows.Forms.Button btnAloita;
    }
}