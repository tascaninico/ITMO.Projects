namespace app
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butAdd = new System.Windows.Forms.Button();
            this.burEdit = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.studDataSet = new app.studDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new app.studDataSetTableAdapters.studentsTableAdapter();
            this.studDataSet1 = new app.studDataSet1();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter1 = new app.studDataSet1TableAdapters.studentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(79, 385);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(107, 23);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // burEdit
            // 
            this.burEdit.Location = new System.Drawing.Point(328, 385);
            this.burEdit.Name = "burEdit";
            this.burEdit.Size = new System.Drawing.Size(121, 23);
            this.burEdit.TabIndex = 2;
            this.burEdit.Text = "Изменить";
            this.burEdit.UseVisualStyleBackColor = true;
            this.burEdit.Click += new System.EventHandler(this.burEdit_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(600, 385);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(112, 23);
            this.butDel.TabIndex = 3;
            this.butDel.Text = "Удалить";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // studDataSet
            // 
            this.studDataSet.DataSetName = "studDataSet";
            this.studDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.studDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studDataSet1
            // 
            this.studDataSet1.DataSetName = "studDataSet1";
            this.studDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "students";
            this.studentsBindingSource1.DataSource = this.studDataSet1;
            // 
            // studentsTableAdapter1
            // 
            this.studentsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.burEdit);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Список студентов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button burEdit;
        private System.Windows.Forms.Button butDel;
        private studDataSet studDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private studDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private studDataSet1 studDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private studDataSet1TableAdapters.studentsTableAdapter studentsTableAdapter1;
    }
}

