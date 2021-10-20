using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nums1a.Text = Properties.Settings.Default.a1.ToString();
            nums1b.Text = Properties.Settings.Default.b1.ToString();
            nums2a.Text = Properties.Settings.Default.a2.ToString();
            nums2b.Text = Properties.Settings.Default.b2.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void nums1a_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            bool isCorrect = true;
            foreach(var ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    if (ctl == result)
                    {
                        continue;
                    }

                    double n = 0;
                    var txtBox = ctl as TextBox;
                    if (!double.TryParse(txtBox.Text, out n))
                    {
                        isCorrect = false;
                        break;
                    }
                }
            }
            if (isCorrect)
            {
                double a1 = double.Parse(nums1a.Text);
                double b1 = double.Parse(nums1b.Text);
                double a2 = double.Parse(nums2a.Text);
                double b2 = double.Parse(nums2b.Text);
                Properties.Settings.Default.a1 = a1;
                Properties.Settings.Default.a2 = a2;
                Properties.Settings.Default.b1 = b1;
                Properties.Settings.Default.b2 = b2;
                Properties.Settings.Default.Save();
                ComplexNum first = new ComplexNum(a1, b1);
                ComplexNum second = new ComplexNum(a2, b2);
                switch (comboBox1.SelectedItem)
                {
                    case "Сложение":
                        result.Text = (first + second).ToString();
                        break;
                    case "Вычитание":
                        result.Text = (first - second).ToString();
                        break;
                    case "Умножение":
                        result.Text = (first * second).ToString();
                        break;
                    case "Деление":
                        result.Text = (first / second).ToString();
                        break;
                    case "Сравнение":
                        result.Text = first.Comparison(first, second);
                        break;
                    default:
                        result.Text = "Выберите действие.";
                        break;
                }
            }
            else
            {
                result.Text = "Некорректные значения.";
           }
        }

        private void nums1b_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void nums2a_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void nums2b_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
