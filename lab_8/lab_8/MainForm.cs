using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace lab_8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        private void MainForm_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = "Data Source=DESKTOP-S86MQFC;Initial Catalog= var5sql;Integrated Security=True";
            cmd.Connection = cnn;
            cnn.Open();
            comboBox1.Items.Add("Упражнение 3 Задание 1.1");
            comboBox1.Items.Add("Упражнение 3 Задание 1.2");
            comboBox1.Items.Add("Упражнение 3 Задание 3");
            comboBox1.SelectedIndexChanged += new System.EventHandler(ComboBox1_SelectedIndexChanged);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {  }
        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (comboBox1.Text)
            {
                
                case "Упражнение 3 Задание 1.1":
                    textBox1.Text = "Дополнить результат запросов  № 1  лабораторной работы № 1  полем «Наименование абонента»  (табл.F1031,F107, F115 ).";
                    cmd.CommandText = "SELECT F1031.abon_nam, F107.NAM_PRIS, F107.TCHK_NAM FROM F107 INNER JOIN F1031 ON F1031.ABON = F107.ABON WHERE NAM_PRIS LIKE '%в ЦРП%'; ";
                    da.SelectCommand = cmd;
                    DataTable dt7 = new DataTable();
                    da.Fill(dt7);
                    dataGridView1.DataSource = dt7;
                    break;
                case "Упражнение 3 Задание 1.2":
                    textBox1.Text = "Дополнить результат запросов  № 2  лабораторной работы № 2  полем «Наименование абонента»  (табл.F1031,F107, F115 ).";
                    cmd.CommandText = "SELECT  COUNT(f115.ABON) AS Number_of_Abonents, f115.ABON , F1031.abon_nam FROM f115 INNER JOIN F1031 ON F1031.ABON = f115.ABON GROUP BY f115.ABON, F1031.abon_nam HAVING COUNT(f115.ABON) > 50 ORDER BY Count(f115.ABON) desc;";
                    da.SelectCommand = cmd;
                    DataTable dt8 = new DataTable();
                    da.Fill(dt8);
                    dataGridView1.DataSource = dt8;
                    break;
              
                case "Упражнение 3 Задание 3":
                    textBox1.Text = "Определить типы мест расположения счетчиков (табл. mounting), не использующиеся в высоковольтных точках учета (табл. F107).";
                    cmd.CommandText = "SELECT mounting.place, F107.place AS tchk_place FROM mounting LEFT JOIN  F107 ON F107.place = mounting.place where F107.place is null";
                    da.SelectCommand = cmd;
                    DataTable dt10 = new DataTable();
                    da.Fill(dt10);
                    dataGridView1.DataSource = dt10;
                    break;
            }
        }
    }
}
