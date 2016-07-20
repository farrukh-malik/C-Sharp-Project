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
    public partial class daily_record : Form
    {
        public OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\mydb.accdb");
        public daily_record()
        {
            InitializeComponent();
               }
        
        public string pname;
        public int qunt;
        public double amount;

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                pname = textBox22.Text;
                qunt = int.Parse(textBox1.Text);
                amount = double.Parse(textBox2.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("correct your input");
                textBox22.Clear();
                textBox2.Clear();
                textBox1.Clear();
            }
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert Into dl(pname, quan, amount) Values('"+pname+"', "+qunt+", "+qunt*amount+")" ,conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            
            }
            catch (Exception ex) { 
            
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sel = 0, TEMP = 0;
        //    try
     ///       {

                conn.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from dl", conn);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {

                    textBox41.Text = dt["amount"].ToString();
                    sel = Int32.Parse(textBox41.Text);
                    TEMP += sel;
                    /// 
                    textBox41.Show();
                    textBox41.Text = TEMP.ToString();
                }


                conn.Close();
         //   }

        /*    catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }*/
           // finally
           // {

                conn.Close();
          //  }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox22.Clear();
            textBox41.Clear()
        }
    }
}
