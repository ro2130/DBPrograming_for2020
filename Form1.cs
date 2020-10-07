using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBprograming
{
    public partial class Form1 : Form //partial->form1의 클래스의 일부라는 얘기
    {
        public Form1()//생성자
        {
            InitializeComponent();//designer.cs에 자동으로 생성된 함수임
        }
        TextBox myTextBox = new TextBox();

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "Hello World";//어떻게 바로 ok와 text박스가 어떻게 바로 연결되나
            
            myTextBox.Text = "MyText...";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
