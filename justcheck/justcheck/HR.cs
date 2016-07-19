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
    public partial class HR : Form
    {
         public HR()
        {
            InitializeComponent();
        }
         public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\mydb.accdb");
       
        public long nic;
        public string name, fname, nation, domicile, religion, status, edu, year, grade, comp, contract, compny, dura,other,phn,post;
        public double sal, conv, bonus;
        public bool medi;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            nic = 0;
            try
            {
                nic = long.Parse(textBox3.Text);
                count++;
            }
            catch (Exception ex) {
                MessageBox.Show("write correct id");
            }
            name = textBox1.Text;
            fname = textBox2.Text;
            if(fname.Equals(name,StringComparison.OrdinalIgnoreCase)){
                MessageBox.Show("father and son name is same so write again");
                textBox1.Clear();
                textBox2.Clear();
            }
            try{

            nation = textBox4.Text;
            domicile = textBox5.Text;
            religion = textBox6.Text;
            status = textBox7.Text;
            phn = textBox34.Text;
            edu = textBox18.Text;
            year = textBox15.Text;
            grade = textBox19.Text;
            comp = textBox44.Text;
            other = textBox38.Text;
            sal = double.Parse(textBox36.Text);
            conv = double.Parse(textBox29.Text);
            bonus = double.Parse(textBox28.Text);
            medi = checkBox1.Checked;
            contract = textBox33.Text;
            compny = textBox8.Text;
            post = textBox9.Text;
            dura = textBox10.Text;
            }
            catch(Exception ex){
            MessageBox.Show("incorrect iput");
            }
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into hr(ID, sname, fname, nationality, domicile, religion, status, edu, years, grade, computer, other, salary, convence, bonus, medical, contract, phone, company, post, duration) Values(" + nic + ",'" + name + "','" + fname + "','" + nation + "','" + domicile + "','" + religion + "','" + status + "','" + edu + "','" + year + "','" + grade + "','" + comp + "','" + other + "'," + sal + "," + conv + "," + bonus + "," + medi + ",'" + contract + "','" + phn + "','" + compny + "','" + post + "','" + dura + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex){
                MessageBox.Show("id yo have entered is same");
            
            }
        }

        private void HR_Load(object sender, EventArgs e)
        {

        }

        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Enter please number only");
                e.KeyChar = (char)0;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hrView aaa = new hrView();
            aaa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hrSearch bbb = new hrSearch();
            bbb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hrDelete ccc = new hrDelete();
            ccc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            nic = 0;
            try
            {
                nic = long.Parse(textBox3.Text);
                count++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("write correct id");
            }
            name = textBox1.Text;
            fname = textBox2.Text;
            if (fname.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("father and son name is same so write again");
                textBox1.Clear();
                textBox2.Clear();
            }
            try
            {

                nation = textBox4.Text;
                domicile = textBox5.Text;
                religion = textBox6.Text;
                status = textBox7.Text;
                phn = textBox34.Text;
                edu = textBox18.Text;
                year = textBox15.Text;
                grade = textBox19.Text;
                comp = textBox44.Text;
                other = textBox38.Text;
                sal = double.Parse(textBox36.Text);
                conv = double.Parse(textBox29.Text);
                bonus = double.Parse(textBox28.Text);
                medi = checkBox1.Checked;
                contract = textBox33.Text;
                compny = textBox8.Text;
                post = textBox9.Text;
                dura = textBox10.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("incorrect iput");
            }
           try
            {
                OleDbCommand cmd = new OleDbCommand("UPDATE hr SET sname='"+name+"',fname='"+fname+"', nationality='"+nation+"', domicile='"+domicile+"', religion='"+religion+"', status='"+status+"', edu='"+edu+"', years='"+year+"', grade='"+grade+"', computer='"+comp+"', other='"+other+"', salary="+sal+", convence="+conv+", bonus="+bonus+", medical="+medi+", contract='"+contract+"', phone='"+phn+"', company='"+compny+"', post='"+post+"', duration='"+dura+"' where ID="+nic+"", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("id yo have entered is same");

            }
        }

      

       
    }
}
