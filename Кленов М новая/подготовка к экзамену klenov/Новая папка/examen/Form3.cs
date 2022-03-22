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
    public partial class Form3 : Form
    {
        connect con = new connect();
        

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CommandText = "INSERT INTO products_k_import1 (NaimenovanieProdukcii, Articul, MinCostForAgent, Image, TypeProduction, CountPeopleForProd, NumberTseh) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','Да','" + textBox6.Text + "','" + textBox3.Text + "')";
            con.sidu_interface(CommandText);
        }
    }
}
