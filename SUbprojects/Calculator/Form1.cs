using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitVariables();
        }
        
        public void InitVariables()
        {
            comboBox1ComboCalc_Operator.Items.Clear();

            comboBox1ComboCalc_Operator.Items.Add("+");
            comboBox1ComboCalc_Operator.Items.Add("-");
            comboBox1ComboCalc_Operator.Items.Add("*");
            comboBox1ComboCalc_Operator.Items.Add("/");

            comboBox1ComboCalc_Operator.SelectedIndex = 0;

            comboBox1ComboCalc_Operator.SelectedIndex = 0;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1ComboCalc_Operator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboboxCalculator_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxComboCalc_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxComboCalc_Oper1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboboxCalculator_Click_1(object sender, EventArgs e)
        {
            String oper1 = textBoxComboCalc_Oper1.Text;
            String oper2 = textBoxComboCalc_Oper2.Text;
            String oper = "";
            int result=0;

            switch (comboBox1ComboCalc_Operator.SelectedIndex)
            {
                case 0://+
                    oper = "+";
                    result=Convert.ToInt32(oper1)+ Convert.ToInt32(oper2);
                    break;
                case 1://-
                    oper = "-";
                    result = Convert.ToInt32(oper1) -Convert.ToInt32(oper2);
                    break;
                case 2://*
                    oper = "*";
                    result = Convert.ToInt32(oper1) * Convert.ToInt32(oper2);
                    break;
                case 3:// /
                    //oper = "/";
                    result = Convert.ToInt32(oper1) / Convert.ToInt32(oper2);
                    break;
            }
            textBoxComboCalc_result.Text = Convert.ToString(result);

        }
    }
}
