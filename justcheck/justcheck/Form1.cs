using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace justcheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


/////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button2_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text == "accounts" && textBox3.Text == "123"){
                     this.timer1.Start(); 
                     accounts.Enabled = true;
                }

            else if (textBox1.Text == "reception" && textBox3.Text == "123"){
                    this.timer1.Start();
                    manager.Enabled = true;
                }

            else if (textBox1.Text == "volunteer" && textBox3.Text == "123"){
                   this.timer1.Start();
                   manager.Enabled = true;
                }

            else if (textBox1.Text == "hr" && textBox3.Text == "123"){
                  this.timer1.Start();
                  hr.Enabled = true;
            }

            
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Show();
            this.progressBar1.Increment(1);

          
        }

        private void hr_Click(object sender, EventArgs e)
        {
            HR obj = new HR();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            accounts obj = new accounts();
            obj.Show();
        }

       

    }
}
