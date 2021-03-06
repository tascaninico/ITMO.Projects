namespace app
{
    partial class frmAdd
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbGod = new System.Windows.Forms.TextBox();
            this.tbAdr = new System.Windows.Forms.TextBox();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Год рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адрес проживания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Отчество";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(151, 22);
            this.tbName.TabIndex = 5;
            // 
            // tbGod
            // 
            this.tbGod.Location = new System.Drawing.Point(239, 29);
            this.tbGod.Name = "tbGod";
            this.tbGod.Size = new System.Drawing.Size(151, 22);
            this.tbGod.TabIndex = 6;
            this.tbGod.TextChanged += new System.EventHandler(this.tbGod_TextChanged);
            this.tbGod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGod_KeyPress);
            // 
            // tbAdr
            // 
            this.tbAdr.Location = new System.Drawing.Point(239, 96);
            this.tbAdr.Name = "tbAdr";
            this.tbAdr.Size = new System.Drawing.Size(151, 22);
            this.tbAdr.TabIndex = 7;
            // 
            // tbFam
            // 
            this.tbFam.Location = new System.Drawing.Point(12, 96);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(151, 22);
            this.tbFam.TabIndex = 8;
            // 
            // tbOtch
            // 
            this.tbOtch.Location = new System.Drawing.Point(12, 179);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(151, 22);
            this.tbOtch.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 334);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.tbAdr);
            this.Controls.Add(this.tbGod);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAdd";
            this.Text = "Добавление\\изменение записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbGod;
        private System.Windows.Forms.TextBox tbAdr;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}