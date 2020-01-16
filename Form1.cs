using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Pokup
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Sum()
        {
            label42.Text = Convert.ToString(Convert.ToDouble(label11.Text) + Convert.ToDouble(label12.Text) +
                                            Convert.ToDouble(label13.Text) + Convert.ToDouble(label14.Text) +
                                            Convert.ToDouble(label15.Text) + Convert.ToDouble(label16.Text) +
                                            Convert.ToDouble(label17.Text) + Convert.ToDouble(label18.Text) +
                                            Convert.ToDouble(label19.Text) + Convert.ToDouble(label20.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(label1.Text);
            if (Int32.TryParse(textBox1.Text, out b))
            {
                label11.Text = Convert.ToString(a * b);
            }
            Sum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "0";
            textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = "0";
            label11.Text = label12.Text = label13.Text = label14.Text = label15.Text = "0";
            label16.Text = label17.Text = label18.Text = label19.Text = label20.Text = "0";
            Sum();

        }
    }
}
