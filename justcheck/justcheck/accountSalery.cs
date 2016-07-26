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
    public partial class accountSalery : Form
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\mydb.accdb");
        public accountSalery()
        {
            InitializeComponent();
        }
        public string name;
        public string mont;
        public int sel = 0, TEMP = 0, id;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                id = Int32.Parse(textBox3.Text);
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from hr where ID=" + id + " ", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {

                    textBox6.Text = dt["Salary"].ToString();
                    name = dt["sname"].ToString();
                    sel = Int32.Parse(textBox6.Text);
                    TEMP = sel;
                    textBox6.Text = TEMP.ToString();
                    textBox9.Text = TEMP.ToString();
                    TEMP = 1;
                }
                textBox2.Text = name;
                textBox11.Text = name;
                textBox10.Text = id.ToString();
                textBox3.Text = TEMP.ToString();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("not execute");
            }
            finally {
                con.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             mont = textBox1.Text;
            string sal = textBox4.Text;
           try
            {
            OleDbCommand cmd = new OleDbCommand("INSERT into rec(sname, salary, monthh,yesno) Values('" + name + "', '" + sel + "', '" + mont + "', '" +sal+  "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("inserted"); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox6.Clear();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountSalery_Load(object sender, EventArgs e)
        {

        }
    }
}
