using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    
    public partial class Form1 : Form
    {
        connect con = new connect();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s1 = "select * FROM productmaterial_k_import";
            dataGridView2.DataSource = con.ConDS(s1).Tables[0];

            string s2 = "select * FROM materials_short_k_import";
            dataGridView1.DataSource = con.ConDS(s2).Tables[0];

            string s3 = "select * FROM products_k_import1";
            dataGridView3.DataSource = con.ConDS(s3).Tables[0];

            string s4 = "select * FROM products_k_import1, materials_short_k_import, productmaterial_k_import";
            dataGridView4.DataSource = con.ConDS(s4).Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
