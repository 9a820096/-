using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int? a = Convert.ToInt32(textBox1.Text);
                if (a > 999)
                {
                    MessageBox.Show("數字必須小於等於999", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (a < 100)
                {
                    MessageBox.Show("數字必須大於等於100", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (a <= 999 & a >= 100)
                {
                    int? result = 0;
                    while (a != 0) { result = result * 10 + a % 10; a /= 10; }
                    if (result > int.MaxValue || result < int.MinValue) ;
                    string c = System.Convert.ToString(result);
                    label2.Text = c;
                }

            }
            catch (Exception)
            {
                {
                    MessageBox.Show("請輸入正確格式", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
        

