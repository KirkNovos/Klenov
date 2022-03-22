using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace examen

{
    class connect
    {
        private MySqlConnection con;
        private string connectString;
        private MySqlDataAdapter adapter;
        private MySqlDataReader dr;
        private MySqlCommand cmd;
        StreamReader sr;

        public connect()
        {
            sr = new StreamReader("stringConnect.ini");
            connectString = sr.ReadLine();
        }
        
        public DataSet ConDS(string sql)//загрузка всей таблицы
        {
            DataSet ds = new DataSet();
            try
            {
                // создаем экземпляр класса MySqlConnection
                con = new MySqlConnection(connectString);
                // открываем соединение с БД
                con.Open();
                adapter = new MySqlDataAdapter(sql, con);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return ds;
        }
        
        public DataTable ConDT2(string sql)
        {
            con = new MySqlConnection(connectString);
            con.Open(); //открываем БД
            DataTable dt = new DataTable();
            cmd = new MySqlCommand(sql, con);
            
            try
            {
             cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();
              dt.Load(dr);
             dr.Close();
             con.Close(); //закрываем соединение, т.к. оно нам больше не нужно
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public string SEL(string sql) //select;insert;update;delit
        {
            DataTable dt = new DataTable();
            string s = "";
            con = new MySqlConnection(connectString);
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            try
            {
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = sql;
                MySqlDataReader dr1 = cmd2.ExecuteReader();
                while (dr1.Read()) // построчно считываем данные
                {
                    s = dr1.GetValue(0).ToString();
                }
                con.Close(); //закрываем соединение, т.к. оно нам больше не нужно
                             // MessageBox.Show("Успешно");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("s=null:"+ex.Message);
                s = null;
            }
            return s;
        }

        new public void sidu_interface(string sql)
        {
            con = new MySqlConnection(connectString);
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            try
            {
                cmd2.CommandText = sql;
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

