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

namespace Session_1
{
    public partial class Form2 : Form
    {
        string conn_string = "Data Source=LAB206_2\\SQLEXPRESS;Initial Catalog = Cpisok_Tovarov; Integrated Security = True";
        public Form2()
        {
            InitializeComponent();
        }

     

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cpisok_TovarovDataSet1.Tovari". При необходимости она может быть перемещена или удалена.
            this.tovariTableAdapter.Fill(this.cpisok_TovarovDataSet1.Tovari);



        }



        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Tovari] where F2 Like '" + textBox1.Text + "%'";
            sql_conn.Open(); // открыть соединение
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            tovariDataGridView.DataSource = dt;
            sql_conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
            this.Hide();
        }

       

        private void tovariBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tovariBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cpisok_TovarovDataSet1);

        }

        private void tovariBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
