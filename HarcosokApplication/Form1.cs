using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        string connString = "Server=localhost;Uid=root;Database=cs_harcosok";
        public MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connString);
                {
                    conn.Open();
                    MySqlCommand SET = new MySqlCommand("Insert into harcosok(nev) values(@nev)", conn);
                    SET.Parameters.AddWithValue("@nev", harcosNeveTextBox.Text);


                    SET.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Van már ilyen név!");
            }
        }

         
    }
}
