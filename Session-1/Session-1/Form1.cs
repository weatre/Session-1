using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Session_1
{
    public partial class Form1 : Form
    {
        string conn_string = "Data Source=LAB206_2\\SQLEXPRESS;Initial Catalog = Cpisok_Tovarov; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
SqlConnection con = new SqlConnection(conn_string);
            string Login, Password;// на текст бокс 1 и текстбокс 2 проводим инициализауцию
            Login = textBox1.Text;//обьбявляем
            Password = textBox2.Text;
            // используем исключение и убираемперегрузку файлов трай кач файноли, чтобы из программы не выбрасывало при неверном коде
            try
            {
                string querry = "SELECT*FROM users WHERE Login='" + textBox1.Text + "'AND Password='" + textBox2.Text + "'";// создаем запрос и выбираем таблицу из БД
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);//построчно можно перебрать ответ от сервера базы данных
                // Объект DataSet содержит таблицы, которые представлены типом DataTable. Таблица, в свою очередь, состоит из столбцов и строк. Каждый столбец представляет объект DataColumn, а строка - объект DataRow.
                DataTable dt = new DataTable();
                // dt.rows.count” (dt – это имя datatable) всегда возвращает 0
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Login = textBox1.Text;
                    Password = textBox2.Text;
                    Form2 form2 = new Form2();// переход на форму 2
                    form2.Show();
                    this.Hide();// закрываем первую форму
                }
                else
                {
                    MessageBox.Show("no robit");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch
            {
                MessageBox.Show("не работает");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
        
       
    

