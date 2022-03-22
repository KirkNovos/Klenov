using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace examen
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl

    {
        connect con = new connect();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            string s = "SELECT * from products_k_import1";
            grid.ItemsSource = con.ConDT2(s).DefaultView;
        }

        private void ContextMenu_insert(object sender, RoutedEventArgs e)
        {
            var item = grid.SelectedItem as DataRowView;
        //    MessageBox.Show(item.DataView[grid.SelectedIndex][0].ToString().Trim());

            Form3 f3 = new Form3();
            f3.Show();
        }
        //Получаем данные из таблицы
        private void ContextMenu_updeit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Изменение записи");
        }
        //Получаем данные из таблицы
        private void ContextMenu_delit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Удаление записи");
        }
        /*
private void grid_Loaded(object sender, RoutedEventArgs e)
{
   string s = "SELECT * from products_k_import1";
   grid.ItemsSource = con.ConDT(s).DefaultView;
   // или con.ConDT(s).AsDataView();//result1;
}
*/
    }
}


