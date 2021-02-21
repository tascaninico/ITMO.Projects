using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_1._5_2
{
    public partial class RectangleForm : Lab_1._5_2.StartForm
    {
        public RectangleForm()
        {
            InitializeComponent();
        }

        private void Rectangle_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, this.Height / 2), new Point(this.Width / 2, 0),
                new Point(this.Width, this.Height / 2), new Point(this.Width / 2, this.Height) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
