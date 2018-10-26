namespace beadandosokpntnulla
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
            this.betoltes = new System.Windows.Forms.Button();
            this.mentes = new System.Windows.Forms.Button();
            this.hozzadas = new System.Windows.Forms.Button();
            this.radioButtonN = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // betoltes
            // 
            this.betoltes.Location = new System.Drawing.Point(188, 331);
            this.betoltes.Name = "betoltes";
            this.betoltes.Size = new System.Drawing.Size(75, 23);
            this.betoltes.TabIndex = 0;
            this.betoltes.Text = "betoltes";
            this.betoltes.UseVisualStyleBackColor = true;
            this.betoltes.Click += new System.EventHandler(this.betoltes_Click);
            // 
            // mentes
            // 
            this.mentes.Location = new System.Drawing.Point(301, 331);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(75, 23);
            this.mentes.TabIndex = 1;
            this.mentes.Text = "mentes";
            this.mentes.UseVisualStyleBackColor = true;
            // 
            // hozzadas
            // 
            this.hozzadas.Location = new System.Drawing.Point(265, 245);
            this.hozzadas.Name = "hozzadas";
            this.hozzadas.Size = new System.Drawing.Size(75, 23);
            this.hozzadas.TabIndex = 2;
            this.hozzadas.Text = "hozzadas";
            this.hozzadas.UseVisualStyleBackColor = true;
            this.hozzadas.Click += new System.EventHandler(this.hozzadas_Click_1);
            // 
            // radioButtonN
            // 
            this.radioButtonN.AutoSize = true;
            this.radioButtonN.Location = new System.Drawing.Point(147, 158);
            this.radioButtonN.Name = "radioButtonN";
            this.radioButtonN.Size = new System.Drawing.Size(33, 17);
            this.radioButtonN.TabIndex = 3;
            this.radioButtonN.TabStop = true;
            this.radioButtonN.Text = "N";
            this.radioButtonN.UseVisualStyleBackColor = true;
            this.radioButtonN.CheckedChanged += new System.EventHandler(this.radioButtonN_CheckedChanged);
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(101, 158);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(31, 17);
            this.radioButtonF.TabIndex = 4;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "F";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(101, 97);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 20);
            this.textBoxD.TabIndex = 5;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(101, 46);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 6;
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(255, 200);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 20);
            this.textBoxH.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Szul Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hobbyk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Uj Hobby";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(255, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 356);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonN);
            this.Controls.Add(this.hozzadas);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.betoltes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button betoltes;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.Button hozzadas;
        private System.Windows.Forms.RadioButton radioButtonN;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

