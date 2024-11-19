namespace Sportolo
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
            this.txnev = new System.Windows.Forms.TextBox();
            this.txeletkor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhozad = new System.Windows.Forms.Button();
            this.btnatlagkor = new System.Windows.Forms.Button();
            this.btnletszam = new System.Windows.Forms.Button();
            this.btnminage = new System.Windows.Forms.Button();
            this.btnmaxage = new System.Windows.Forms.Button();
            this.btnszaksportmen = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txnev
            // 
            this.txnev.BackColor = System.Drawing.Color.LemonChiffon;
            this.txnev.Location = new System.Drawing.Point(113, 31);
            this.txnev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(148, 20);
            this.txnev.TabIndex = 0;
            // 
            // txeletkor
            // 
            this.txeletkor.BackColor = System.Drawing.Color.LemonChiffon;
            this.txeletkor.Location = new System.Drawing.Point(133, 99);
            this.txeletkor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txeletkor.Name = "txeletkor";
            this.txeletkor.Size = new System.Drawing.Size(116, 20);
            this.txeletkor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Életkor";
            // 
            // btnhozad
            // 
            this.btnhozad.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnhozad.Location = new System.Drawing.Point(54, 146);
            this.btnhozad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnhozad.Name = "btnhozad";
            this.btnhozad.Size = new System.Drawing.Size(172, 65);
            this.btnhozad.TabIndex = 4;
            this.btnhozad.Text = "Hozzáadás";
            this.btnhozad.UseVisualStyleBackColor = false;
            this.btnhozad.Click += new System.EventHandler(this.btnhozad_Click);
            // 
            // btnatlagkor
            // 
            this.btnatlagkor.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnatlagkor.Location = new System.Drawing.Point(78, 322);
            this.btnatlagkor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnatlagkor.Name = "btnatlagkor";
            this.btnatlagkor.Size = new System.Drawing.Size(147, 46);
            this.btnatlagkor.TabIndex = 5;
            this.btnatlagkor.Text = "Átlag életkor";
            this.btnatlagkor.UseVisualStyleBackColor = false;
            this.btnatlagkor.Click += new System.EventHandler(this.btnatlagkor_Click);
            // 
            // btnletszam
            // 
            this.btnletszam.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnletszam.Location = new System.Drawing.Point(78, 383);
            this.btnletszam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnletszam.Name = "btnletszam";
            this.btnletszam.Size = new System.Drawing.Size(147, 46);
            this.btnletszam.TabIndex = 6;
            this.btnletszam.Text = "Gyermek csapat létszáma";
            this.btnletszam.UseVisualStyleBackColor = false;
            this.btnletszam.Click += new System.EventHandler(this.btnletszam_Click);
            // 
            // btnminage
            // 
            this.btnminage.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnminage.Location = new System.Drawing.Point(258, 322);
            this.btnminage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnminage.Name = "btnminage";
            this.btnminage.Size = new System.Drawing.Size(147, 46);
            this.btnminage.TabIndex = 7;
            this.btnminage.Text = "Legfiatalabb játékos";
            this.btnminage.UseVisualStyleBackColor = false;
            this.btnminage.Click += new System.EventHandler(this.btnminage_Click);
            // 
            // btnmaxage
            // 
            this.btnmaxage.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnmaxage.Location = new System.Drawing.Point(258, 383);
            this.btnmaxage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnmaxage.Name = "btnmaxage";
            this.btnmaxage.Size = new System.Drawing.Size(147, 46);
            this.btnmaxage.TabIndex = 8;
            this.btnmaxage.Text = "Legidősebb játékos";
            this.btnmaxage.UseVisualStyleBackColor = false;
            this.btnmaxage.Click += new System.EventHandler(this.btnmaxage_Click_1);
            // 
            // btnszaksportmen
            // 
            this.btnszaksportmen.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnszaksportmen.Location = new System.Drawing.Point(429, 322);
            this.btnszaksportmen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnszaksportmen.Name = "btnszaksportmen";
            this.btnszaksportmen.Size = new System.Drawing.Size(173, 107);
            this.btnszaksportmen.TabIndex = 9;
            this.btnszaksportmen.Text = "Szakaszosztály sportolóinak mentése";
            this.btnszaksportmen.UseVisualStyleBackColor = false;
            this.btnszaksportmen.Click += new System.EventHandler(this.btnszaksportmen_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnexit.Location = new System.Drawing.Point(623, 322);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(173, 107);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Kilépés";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // rtb
            // 
            this.rtb.BackColor = System.Drawing.Color.LemonChiffon;
            this.rtb.Location = new System.Drawing.Point(373, 31);
            this.rtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(434, 265);
            this.rtb.TabIndex = 11;
            this.rtb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnszaksportmen);
            this.Controls.Add(this.btnmaxage);
            this.Controls.Add(this.btnminage);
            this.Controls.Add(this.btnletszam);
            this.Controls.Add(this.btnatlagkor);
            this.Controls.Add(this.btnhozad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txeletkor);
            this.Controls.Add(this.txnev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sportolói jegyzék";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.TextBox txeletkor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhozad;
        private System.Windows.Forms.Button btnatlagkor;
        private System.Windows.Forms.Button btnletszam;
        private System.Windows.Forms.Button btnminage;
        private System.Windows.Forms.Button btnmaxage;
        private System.Windows.Forms.Button btnszaksportmen;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.RichTextBox rtb;
    }
}

