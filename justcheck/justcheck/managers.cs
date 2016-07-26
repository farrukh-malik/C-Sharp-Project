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
    public partial class managers : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\mydb.accdb");
        public managers()
        {
            InitializeComponent();
        }
        public string tablename;
        private void button1_Click(object sender, EventArgs e)
        {
            try{
            tablename= textBox1.Text;
            if (tablename.Equals("dl", StringComparison.Ordinal) || tablename.Equals("hr", StringComparison.Ordinal))
            {
                OleDbCommand read = new OleDbCommand("Select * from " + tablename + "", con);

                OleDbDataAdapter a = new OleDbDataAdapter();
                a.SelectCommand = read;
                DataTable dt = new DataTable();
                a.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                a.Update(dt);
            }
            else
            {
                MessageBox.Show("please enter correct table name");
            }
            }
            catch(Exception ex){
            
            }
        }
    }
}
