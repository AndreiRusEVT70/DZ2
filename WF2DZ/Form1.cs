using System;
using System.Windows.Forms;

namespace WF2DZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fnumber = float.Parse(textBox1.Text);
            float snumber = float.Parse(textBox2.Text);
            float result = 0;
            string operation = comboBox1.Text;

            switch (operation)
            {
                case "Сложение":
                    result = fnumber + snumber;
                    textBox3.Text = result.ToString();
                    break;

                case "Вычитание":
                    result = fnumber - snumber;
                    textBox3.Text = result.ToString();
                    break;

                case "Умножение":
                    result = fnumber * snumber;
                    textBox3.Text = result.ToString();
                    break;

                case "Деление":
                    result = fnumber / snumber;
                    textBox3.Text = result.ToString();
                    break;
            }

        }

    }
}
