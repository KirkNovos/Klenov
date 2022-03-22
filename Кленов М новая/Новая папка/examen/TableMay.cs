using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace examen
{
    class TableMay
    {
        connect con = new connect();
        string[] si = new string[21];
        string[] np = new string[21];
        string[] st = new string[21];
        string[] sd = new string[21];
        string[] ar = new string[21];
        string[] mt = new string[21];
        string[] mts = new string[21];
        string[] sel = new string[21];
        DataTable DtList = new DataTable();
        DataTable dr;
        public TableMay()
        {
            DtList.TableName = "NewTab";
            DtList.Columns.Add("id", typeof(int));
            DtList.Columns.Add("Image", typeof(string));
            DtList.Columns.Add("title", typeof(string));
            DtList.Columns.Add("Description", typeof(string));
            DtList.Columns.Add("MinCostForAgent", typeof(string));
            DtList.Columns.Add("ProductTypeID", typeof(string));
            DtList.Columns.Add("NameMaterial", typeof(string));
        }
            public DataTable ForList(int min1, int max1)
            {
                DtList.Clear();
                int j = 0;
                for (int i = min1; i < max1; i++)
                {
                    si[j] = "SELECT Image from products_k_import1 where id='" + i + "'";
                    np[j] = "SELECT NaimenovanieProdukcii from products_k_import1 where id='" + i + "'";
                    sd[j] = "SELECT Articul from products_k_import1 where id='" + i + "'";
                    st[j] = "SELECT MinCostForAgent from products_k_import1 where id='" + i + "'";
                    ar[j] = "SELECT TypeProduction from products_k_import1 where id='" + i + "'";
                    mt[j] = "SELECT pm.Name from products_k_import1 p, productmaterial_k_import pm " +
                    "where p.id='" + i + "' and pm.Production=p.NaimenovanieProdukcii";

                string result = Regex.Match(con.SEL(st[j]), @"\d+\.*\d").Value;

                    dr = con.ConDT2(mt[j]);
                    foreach (DataRow dr1 in dr.Rows) mts[j] = mts[j] + "; " + dr1[0];
                    DtList.Rows.Add(j + 1, con.SEL(si[j]), con.SEL(sd[j]), con.SEL(np[j]),
                    result, con.SEL(ar[j]), mts[j]);
                    j++;
                }
                return DtList;
            }
        }
    }

