using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Text = "Русский текст";
        }
    }
}
