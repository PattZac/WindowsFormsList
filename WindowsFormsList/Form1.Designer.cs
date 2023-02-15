namespace WindowsFormsList
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
            this.txtBoxMarke = new System.Windows.Forms.TextBox();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.cmbBoxVrsta = new System.Windows.Forms.ComboBox();
            this.bntUnos = new System.Windows.Forms.Button();
            this.txtBoxIspis = new System.Windows.Forms.TextBox();
            this.bntIspis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bntObradu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxMarke
            // 
            this.txtBoxMarke.AccessibleName = "";
            this.txtBoxMarke.Location = new System.Drawing.Point(13, 27);
            this.txtBoxMarke.Name = "txtBoxMarke";
            this.txtBoxMarke.Size = new System.Drawing.Size(121, 20);
            this.txtBoxMarke.TabIndex = 0;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(12, 79);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(121, 20);
            this.txtBoxModel.TabIndex = 1;
            // 
            // cmbBoxVrsta
            // 
            this.cmbBoxVrsta.FormattingEnabled = true;
            this.cmbBoxVrsta.Items.AddRange(new object[] {
            "Avion",
            "Automobilu",
            "Brod"});
            this.cmbBoxVrsta.Location = new System.Drawing.Point(13, 131);
            this.cmbBoxVrsta.Name = "cmbBoxVrsta";
            this.cmbBoxVrsta.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxVrsta.TabIndex = 2;
            // 
            // bntUnos
            // 
            this.bntUnos.Location = new System.Drawing.Point(35, 189);
            this.bntUnos.Name = "bntUnos";
            this.bntUnos.Size = new System.Drawing.Size(75, 23);
            this.bntUnos.TabIndex = 3;
            this.bntUnos.Text = "&Unos";
            this.bntUnos.UseVisualStyleBackColor = true;
            this.bntUnos.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxIspis
            // 
            this.txtBoxIspis.Location = new System.Drawing.Point(191, 26);
            this.txtBoxIspis.Multiline = true;
            this.txtBoxIspis.Name = "txtBoxIspis";
            this.txtBoxIspis.Size = new System.Drawing.Size(735, 126);
            this.txtBoxIspis.TabIndex = 11;
            this.txtBoxIspis.TabStop = false;
            // 
            // bntIspis
            // 
            this.bntIspis.Location = new System.Drawing.Point(383, 189);
            this.bntIspis.Name = "bntIspis";
            this.bntIspis.Size = new System.Drawing.Size(75, 23);
            this.bntIspis.TabIndex = 10;
            this.bntIspis.Text = "&Ispis";
            this.bntIspis.UseVisualStyleBackColor = true;
            this.bntIspis.Click += new System.EventHandler(this.bntIspis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vrsta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ispis";
            // 
            // bntObradu
            // 
            this.bntObradu.Location = new System.Drawing.Point(205, 189);
            this.bntObradu.Name = "bntObradu";
            this.bntObradu.Size = new System.Drawing.Size(75, 23);
            this.bntObradu.TabIndex = 5;
            this.bntObradu.Text = "&Obradu";
            this.bntObradu.UseVisualStyleBackColor = true;
            this.bntObradu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 236);
            this.Controls.Add(this.bntObradu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntIspis);
            this.Controls.Add(this.txtBoxIspis);
            this.Controls.Add(this.bntUnos);
            this.Controls.Add(this.cmbBoxVrsta);
            this.Controls.Add(this.txtBoxModel);
            this.Controls.Add(this.txtBoxMarke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMarke;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.ComboBox cmbBoxVrsta;
        private System.Windows.Forms.Button bntUnos;
        private System.Windows.Forms.TextBox txtBoxIspis;
        private System.Windows.Forms.Button bntIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntObradu;
    }
}

