using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace examen
{
    public partial class Form2 : Form
    {
        UserControl1 wpfControl = new UserControl1();
        UserControl3 wpfControl1 = new UserControl3();
        public Form2()
        {
            InitializeComponent();
            elementHost1.Child = wpfControl;
            elementHost2.Child = wpfControl1;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

       

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            

        }

        private void новаяЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            



            f3.Show();
        }

        
    }
}
