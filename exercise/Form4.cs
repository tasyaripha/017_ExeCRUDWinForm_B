using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise
{
    public partial class Form4 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet2.Periode' table. You can move, or remove it, as needed.
            this.periodeTableAdapter.Fill(this.prodiTIDataSet2.Periode);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = prodiTIDataSet2.Tables["Kuliah.Periode"];
            dr = dt.NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dt.Rows.Add(dr);
            periodeTableAdapter.Update(prodiTIDataSet2);
            textBox1.Text = System.Convert.ToString(dr[0]);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            this.periodeTableAdapter.Fill(this.prodiTIDataSet2.Periode);
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string code;
            code = textBox1.Text;
            dr = prodiTIDataSet2.Tables["Kuliah.Periode"].Rows.Find(code);
            dr.Delete();
            periodeTableAdapter.Update(prodiTIDataSet2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
