﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        public ParentForm()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            spWin.Text = "Windows are cascade";
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            spWin.Text = "Windows are horizontal";
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            
            ChildForm newChild = new ChildForm();
            newChild.Text = newChild.Text + "" + ++openDocuments;
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {
        
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e. ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text+" "+ ++openDocuments;
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
                case "Tile":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
            }
        }

        private void spWin_Click(object sender, EventArgs e)
        {
            
        }
    }

       
    }
