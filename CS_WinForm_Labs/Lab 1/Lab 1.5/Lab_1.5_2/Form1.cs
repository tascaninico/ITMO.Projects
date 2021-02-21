using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1._5_2
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            myPath1.AddPolygon(new Point[] { new Point(0,0), new Point(this.Width, 0),
                new Point(this.Width, this.Height), new Point(0, this.Height) });
            Region MyRegion = new Region(myPath1);
            this.Region = MyRegion;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RectangleForm rectangle = new RectangleForm();
            rectangle.MdiParent = this;
            rectangle.Show();
        }
    }
}
