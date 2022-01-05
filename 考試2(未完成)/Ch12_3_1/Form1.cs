using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_3_1
{
    public partial class Form1 : Form
    {
        delegate int Mydelegate(int opd1,int opd2);
        class MyMath
        {
            public static int add(int opd1, int opd2)
            {
                return opd1 + opd2;
            }
            public static int sub(int opd1, int opd2)
            {
                return opd1 - opd2;
            }
            public static int mul(int opd1, int opd2)
            {
                return opd1 * opd2;
            }
            public static int div(int opd1, int opd2)
            {
                return opd1 / opd2;
            }
        }
        int a, b;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double? a = Convert.ToDouble(textBox1.Text);
                if (a != -999999)
                {
                    string x = label1.Text;
                    string y = label3.Text;
                    int opd1 = int.Parse(x);
                    int opd2 = int.Parse(y);
                    int z = int.Parse(x)+int.Parse(y);
                    string z1 = z.ToString();
                    if(label2.Text=="+")
                    {
                        Mydelegate handler = new Mydelegate(MyMath.add);
                    }
                    if (label2.Text == "-")
                    {
                        Mydelegate handler = new Mydelegate(MyMath.sub);
                    }
                    if (label2.Text == "*")
                    {
                        Mydelegate handler = new Mydelegate(MyMath.mul);
                    }
                    if (label2.Text == "/")
                    {
                        Mydelegate handler = new Mydelegate(MyMath.div);
                    }
                    if (textBox1.Text==z1)
                    {
                        txtOutput.Text += (x + (label2.Text) + y + "=" + z1 + ",O" + "\r\n");
                        MessageBox.Show("答對了", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    if (textBox1.Text!=z1)
                    {
                        txtOutput.Text += (x + (label2.Text) + y + "=" + z1 + ",X"+"\r\n");
                        MessageBox.Show("答錯了!答案是"+z1, "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                    MessageBox.Show("輸入格式不正確", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            a = rnd.Next(9) + 1;
            b = rnd.Next(9) + 1;
            if (radioButton1.Checked)
            {
                label2.Text = "+";
            }
            else if (radioButton2.Checked)
            {
                label2.Text = "-";
            }
            else if (radioButton3.Checked)
            {
                label2.Text = "*";
            }
            else if (radioButton4.Checked)
            {
                label2.Text = "/";
            }
            label1.Text = a.ToString();
            label3.Text = b.ToString();
            textBox1.Text = "";
        }
      
    }
}
