using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|stud.mdf;Persist Security Info=False";
        SqlConnection conn;
        bool connected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conncect();
        }
        public void conncect()
        {
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                if (conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Не удалось соединится с базой данных");
                }
                else
                {
                    connected = true;
                    fill();
                }

            }
            catch(Exception w)
            {
                MessageBox.Show("Не удалось соединится с базой данных");
            }
        }
        public void fill()
        {
            try
            {
                if (!connected)
                    return;
                string SqlText = "SELECT * FROM students ";
                SqlDataAdapter adapter = new SqlDataAdapter(SqlText, connectionString);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "students");
                dataGridView1.DataSource = ds.Tables["students"].DefaultView;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Имя";
                dataGridView1.Columns[2].HeaderText = "Фамилия";
                dataGridView1.Columns[3].HeaderText = "Отчество";
                dataGridView1.Columns[4].HeaderText = "Год рождения";
                dataGridView1.Columns[5].HeaderText = "Адрес проживания";
            }
            catch(Exception w)
            {
                int s = 1;
            }
        }
        void delete(DataGridView tbl, string tableName)
        {
            DialogResult result = MessageBox.Show(
              "Вы действительно хотите удалить запись?",
              "Подтверждение",
              MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string SqlText = "DELETE FROM " + tableName + " WHERE id=";
                SqlText += tbl[0, tbl.CurrentRow.Index].Value.ToString();
                MyExecuteNonQuery(SqlText);
                fill();
            }
        }
        public void MyExecuteNonQuery(string SqlText)
        {
            try
            {
                SqlCommand cmd = this.conn.CreateCommand();
                cmd.CommandText = SqlText;
                cmd.ExecuteNonQuery();
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            frmAdd frm = new frmAdd();
            frm.ShowDialog();
            if(frm.result)
            {
                MyExecuteNonQuery("insert into students values (" + frm.strRes + ")");
                fill();
            }
        }

        private void burEdit_Click(object sender, EventArgs e)
        {
            frmAdd frm = new frmAdd(true, dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString(), 
                dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString(), 
                dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString(), 
                dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString());
            frm.ShowDialog();
            if(frm.result)
            {
                MyExecuteNonQuery("update students set " + frm.strRes + " where id = '"+ dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString() + "'");
                fill();
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            delete(dataGridView1, "students");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
