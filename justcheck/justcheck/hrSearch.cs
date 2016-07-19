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
    public partial class hrSearch : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\mydb.accdb");
       
        public hrSearch()
        {
            InitializeComponent();
        }

        public int rec;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                rec = Int32.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID to likho");
                textBox1.Clear();
            }
            try
            {
                rec = Int32.Parse(textBox1.Text);
                OleDbCommand read = new OleDbCommand("Select * from hr WHERE ID=" + rec + "", con);

                OleDbDataAdapter a = new OleDbDataAdapter();
                a.SelectCommand = read;
                DataTable dt = new DataTable();
                a.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                a.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("correct nic");
                textBox1.Clear();


            }
        }
    }
}
