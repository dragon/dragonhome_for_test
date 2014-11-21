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

namespace sharp_test_git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "Test";
            int a = 67;
            var b = a * 8;
            b += 12;
            Text = b.ToString();
            // Изменения
            Text = "Русский текст 111";
            var myCon = new SqlConnection("server=dvtg-sp;" +
                                       "Trusted_Connection=yes;" +
                                       "database=zvs_t_blank; " +
                                       "connection timeout=30");
            myCon.Open();
            var c = new SqlCommand("select * from test",myCon);
            //var reader = c.ExecuteReader();
            
            

            var adapter = new SqlDataAdapter();
            adapter.SelectCommand = c;
            var t = new DataTable();
            adapter.Fill(t);
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = t;

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bindingSource1;
            
            myCon.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zvs_t_blankDataSet._Tables' table. You can move, or remove it, as needed.
            this._TablesTableAdapter.Fill(this.zvs_t_blankDataSet._Tables);

        }
    }
}
