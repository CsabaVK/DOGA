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
            FillitTB();
            TextboxFill();
        }

        private void TextboxFill()
        {
            conn.Open();
            var cmd = new SqlCommand("SELECT * FROM rendelesek;", conn);
            var r = cmd.ExecuteReader();
            int count = 0;
            while (r.Read())
            {
                count++;
            }
            textBox1.Text = Convert.ToString(count);

            conn.Close();
            conn.Open();

            var cmd2 = new SqlCommand("select * from rendelesek where termek like '%tojás%'; ", conn);
            var r2 = cmd.ExecuteReader();
            int eggcount = 0;
            while (r2.Read())
            {
                eggcount++;
            }
            textBox2.Text = Convert.ToString(eggcount);

            conn.Close();


        }

        private void FillitTB()
        {
            conn.Open();
            var cmd = new SqlCommand("SELECT * FROM rendelesek;", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                richTextBox1.Text += string.Format("{2} ({1}db) \n",
                   r[0],
                   r[1],
                   r[2]);
            }
            conn.Close();
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

        

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
