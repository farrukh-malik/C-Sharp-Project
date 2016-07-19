using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace justcheck
{
    public partial class hrDelete : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\mydb.accdb");
       
        public hrDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dl = Int32.Parse(textBox1.Text);
                OleDbCommand dlt = new OleDbCommand("DELETE FROM hr Where ID=" + dl + "", con);
                con.Open();
                dlt.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't delete ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand dlt = new OleDbCommand("DELETE FROM hr", con);
                con.Open();
                dlt.ExecuteNonQuery();
                con.Close();
                //Deleterecordspage dl = new Deleterecordspage();
               // this.Hide();
                //dl.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't Delete");
            }
        }
    }
}
