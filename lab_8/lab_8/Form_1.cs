using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    public partial class Form_1 : Form
    {
        public Form_1()
        {
            InitializeComponent();
        }

        private void Form_1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "var5sqlDataSet_views.view_3". При необходимости она может быть перемещена или удалена.
            this.view_3TableAdapter.Fill(this.var5sqlDataSet_views.view_3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "var5sqlDataSet_views.view_2". При необходимости она может быть перемещена или удалена.
            this.view_2TableAdapter.Fill(this.var5sqlDataSet_views.view_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "var5sqlDataSet_views.view_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.var5sqlDataSet_views.view_1);

        }
    }
}
