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

namespace _11_28_Garaguly_Csaba
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            
            conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=nagyker;");
            InitializeComponent();
            Fillit();
        }

        private void Fillit()
        {
            conn.Open();
            var cmd = new SqlCommand("SELECT * FROM boltok;", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {


                dtg_adat.Rows.Add(r[0], r[1], r[2]);
            }

            conn.Close();
        }
    }
}
