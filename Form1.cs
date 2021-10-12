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
                double n = 0;
                if (double.TryParse(nums1a.Text, out n) && double.TryParse(nums2b.Text, out n) && double.TryParse(nums2a.Text, out n) && double.TryParse(nums1b.Text, out n))
                {
                double a1 = double.Parse(nums1a.Text);
                double b1 = double.Parse(nums1b.Text);
                double a2 = double.Parse(nums2a.Text);
                double b2 = double.Parse(nums2b.Text);
                ComplexNum first = new ComplexNum(a1, b1);
                ComplexNum second = new ComplexNum(a2, b2);
                switch (comboBox1.SelectedItem)
                    {
                    case "Сложение":
                        result.Text = first.sum(first, second);
                        break;
                    case "Вычитание":
                        result.Text = first.minus(first, second);
                        break;
                    case "Умножение":
                        result.Text =first.ymnojenie(first,second);
                        break;
                    case "Деление":
                        result.Text=first.delenie(first,second);
                        break;
                    case "Сравнение векторов":
                        result.Text = first.sravnenie(first, second);
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
    }
}
