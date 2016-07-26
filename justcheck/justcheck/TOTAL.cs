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
    public partial class TOTAL : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\mydb.accdb");
        public TOTAL()
        {
            InitializeComponent();
        }

        private void TOTAL_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double quant = 0,total=0;
            try
            {
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from dl", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    quant += double.Parse(dt["quan"].ToString());
                    total += double.Parse(dt["amount"].ToString());
                }
                textBox1.Text = quant.ToString();
                textBox2.Text = total.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("not execute");
            }
        }
    }
}
