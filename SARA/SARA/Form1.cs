using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += button1.Text;
            textBox2.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += button2.Text;
            textBox2.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += button3.Text;
            textBox2.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += button4.Text;
            textBox2.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += button5.Text;
            textBox2.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += button6.Text;
            textBox2.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            switch (textBox2.Text)
            {
                case string a when a.EndsWith("ก"):
                    button1.Text = "การเรียนรู้";
                    button2.Text = "การดำเนินการจัดการเรียนการสอน";
                    button3.Text = "การงานอาชีพและเทคโนโลยี";
                    button4.Text = "การศึกษา";
                    button5.Text = " ก็";
                    button6.Text = " กับ";
                    break;
                case string a when a.EndsWith("ข"):
                    button1.Text = "ขณะที่";
                    button2.Text = "ขาด";
                    button3.Text = "ขยัน";
                    button4.Text = "ขยุม";
                    break;
                case string a when a.EndsWith("ค"):
                    button1.Text = "ควบ";
                    button2.Text = "คำ";
                    button3.Text = "ความ";
                    button4.Text = "คง";
                    button5.Text = "คุณค่า";
                    button6.Text = "คุณธรรม";
                    break;
                case string a when a.EndsWith("แ"):
                    button1.Text = " และ";
                    button2.Text = " แปร";
                    button3.Text = " แปล";
                    button4.Text = " แปล";
                    button5.Text = "และการพัฒนา";
                    button6.Text = "และความเข้าใจอันเป็นอย่างดี";
                    break;
                case string a when a.EndsWith("ด"):
                    button1.Text = " ด้วย";
                    button2.Text = " ดี";
                    button3.Text = " ด้วยความรู้";
                    button4.Text = " ด้วยความเข้าใจ";
                    button5.Text = " ด้วยความเมตตา";
                    button6.Text = " ด้วยความเคารพ";
                    break;
                default:
                    break;

            }
        }
    }
}
