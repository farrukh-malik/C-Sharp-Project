﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int sel = 0, TEMP = 0,id;
         //   try
           // {
                id =Int32.Parse( textBox3.Text);
                con.Open();
                OleDbDataReader dt = null;
                OleDbCommand cmd = new OleDbCommand("Select * from hr where ID="+id+" ", con);
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {

                    textBox6.Text = dt["Salary"].ToString();
                    sel = Int32.Parse(textBox6.Text);
                    TEMP = sel;
                    textBox6.Text = TEMP.ToString();
                    TEMP = 1;
                }
                textBox3.Text = TEMP.ToString();

                con.Close();
          //  }

          //  catch (Exception ex)
           // {
           //     MessageBox.Show("not execute");
           // }
        }
    }
}
