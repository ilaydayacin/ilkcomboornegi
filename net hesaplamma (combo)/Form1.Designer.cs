namespace net_hesaplamma__combo_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.cmbDogru = new System.Windows.Forms.ComboBox();
            this.cmbYanlis = new System.Windows.Forms.ComboBox();
            this.btnHesaplama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yanlış";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNet.Location = new System.Drawing.Point(56, 157);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(57, 29);
            this.lblNet.TabIndex = 2;
            this.lblNet.Text = "Net:";
            // 
            // cmbDogru
            // 
            this.cmbDogru.FormattingEnabled = true;
            this.cmbDogru.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbDogru.Location = new System.Drawing.Point(112, 56);
            this.cmbDogru.Name = "cmbDogru";
            this.cmbDogru.Size = new System.Drawing.Size(121, 21);
            this.cmbDogru.TabIndex = 3;
            // 
            // cmbYanlis
            // 
            this.cmbYanlis.FormattingEnabled = true;
            this.cmbYanlis.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbYanlis.Location = new System.Drawing.Point(115, 94);
            this.cmbYanlis.Name = "cmbYanlis";
            this.cmbYanlis.Size = new System.Drawing.Size(121, 21);
            this.cmbYanlis.TabIndex = 4;
            // 
            // btnHesaplama
            // 
            this.btnHesaplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesaplama.Location = new System.Drawing.Point(242, 143);
            this.btnHesaplama.Name = "btnHesaplama";
            this.btnHesaplama.Size = new System.Drawing.Size(148, 62);
            this.btnHesaplama.TabIndex = 5;
            this.btnHesaplama.Text = "Hesaplama";
            this.btnHesaplama.UseVisualStyleBackColor = true;
            this.btnHesaplama.Click += new System.EventHandler(this.btnHesaplama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 229);
            this.Controls.Add(this.btnHesaplama);
            this.Controls.Add(this.cmbYanlis);
            this.Controls.Add(this.cmbDogru);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.ComboBox cmbDogru;
        private System.Windows.Forms.ComboBox cmbYanlis;
        private System.Windows.Forms.Button btnHesaplama;
    }
}

