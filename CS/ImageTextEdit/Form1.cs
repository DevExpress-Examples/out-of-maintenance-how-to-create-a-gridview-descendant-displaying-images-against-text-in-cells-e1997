using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageTextEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);
        }

        private void customGridView1_OnSmartIconSelection(object sender, OnSmartIconSelectionEventArgs e)
        {
            if (e.CellInfo.Column.FieldName == "ContactName")
                if (e.IsActiveEditor)
                    e.ImageIndex = 0;
                else
                    e.ImageIndex = 1;
            if (e.CellInfo.Column.FieldName == "City" )
                if (e.IsActiveEditor)
                    e.ImageIndex = 2;
                else
                    e.ImageIndex = 3;
            if (e.CellInfo.Column.FieldName == "Country" )
                if (e.IsActiveEditor)
                    e.ImageIndex = 4;
                else
                    e.ImageIndex = 5;

        }
    }
}