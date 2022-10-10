using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iNSPECTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iNSPECTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.var5sqlDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            view_2DataGridView.DataSource = var5sqlDataSet1.Tables["view_2"];

            // TODO: This line of code loads data into the 'var5sqlDataSet1.view_1' table. You can move, or remove it, as needed.
            this.view_1TableAdapter.Fill(this.var5sqlDataSet1.view_1);
            // TODO: This line of code loads data into the 'var5sqlDataSet1.view_2' table. You can move, or remove it, as needed.
            this.view_2TableAdapter.Fill(this.var5sqlDataSet1.view_2);
            // TODO: This line of code loads data into the 'var5sqlDataSet1.view_1' table. You can move, or remove it, as needed.
            //this.view_1TableAdapter.Fill(this.var5sqlDataSet1.view_1);
            // TODO: This line of code loads data into the 'var5sqlDataSet.INSPECT' table. You can move, or remove it, as needed.
            //this.iNSPECTTableAdapter.Fill(this.var5sqlDataSet.INSPECT);
        }

        private void view_2BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
