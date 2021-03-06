using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class frmAdd : Form
    {
        public bool result = false;
        public bool isEdit = false;

        public string strRes = "";
        public frmAdd(bool isEdit= false, string name = "", string fam = "",string otch = "", string god = "", string adr = "")
        {
            InitializeComponent();
            this.isEdit = isEdit;
            tbName.Text = name;
            tbFam.Text = fam;
            tbOtch.Text = otch;
            tbGod.Text = god;
            tbAdr.Text = adr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = true;
            if(!isEdit)
               strRes = "'"+tbName.Text+"','"+tbFam.Text+"','"+tbOtch.Text+"','"+tbGod.Text+"','"+tbAdr.Text+"'";
            else
                strRes = "name = '" + tbName.Text + "', " +
                    "fam = '" + tbFam.Text + "'," +
                    "otch = '" + tbOtch.Text + "'," +
                    "godR = '" + tbGod.Text + "'," +
                    "adress = '" + tbAdr.Text + "'";
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = false;
            Close();
        }

        private void tbGod_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbGod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number)&&(!Char.IsControl(number)))
            {
                e.Handled = true;
            }
        }
    }
}
