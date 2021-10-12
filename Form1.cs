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
            //if (nums1a.Text != string.Empty && nums2a.Text != string.Empty && nums2b.Text != string.Empty && nums1b.Text != string.Empty)
          //  {
                double n = 0;
                if (double.TryParse(nums1a.Text, out n) && double.TryParse(nums2b.Text, out n) && double.TryParse(nums2a.Text, out n) && double.TryParse(nums1b.Text, out n))
                {
                    switch (comboBox1.SelectedItem)
                    {
                        case "Сложение":
                            double a = 0, b = 0;
                            a = double.Parse(nums1a.Text);
                            b = double.Parse(nums1b.Text);
                            ComplexNum first = new ComplexNum(a, b);
                            a = double.Parse(nums2a.Text);
                            b = double.Parse(nums2b.Text);
                            ComplexNum second = new ComplexNum(a, b);
                            result.Text = first.sum(first, second);
                            break;

                        default:
                            result.Text = "Выберите действие.";
                            break;
                    }
                }
           // }
            else
            {
                result.Text = "Некорректные значения.";
            }
        }
    }
}
