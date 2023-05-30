using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cpisok_TovarovDataSet1.Tovari". При необходимости она может быть перемещена или удалена.
            this.tovariTableAdapter.Fill(this.cpisok_TovarovDataSet1.Tovari);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cpisok_TovarovDataSet._Tovari_". При необходимости она может быть перемещена или удалена.
            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        
    }
}
