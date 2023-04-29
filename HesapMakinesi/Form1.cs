using System.Diagnostics;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("1. Sayı alanı boş.");
                return;
            }

            else if (textBox2.Text == "")
            {
                MessageBox.Show("2. Sayı alanı boş.");
                return;
            }

            else

            {

                int sayi1, sayi2, toplam;

                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                toplam = sayi1 + sayi2;

                label3.Text = toplam.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("1. Sayı alanı boş.");
                return;
            }

            else if (textBox2.Text == "")
            {
                MessageBox.Show("2. Sayı alanı boş.");
                return;
            }

            else

            {

                int sayi1, sayi2, toplam;

                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                toplam = sayi1 - sayi2;

                label3.Text = toplam.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("1. Sayı alanı boş.");
                return;
            }

            else if (textBox2.Text == "")
            {
                MessageBox.Show("2. Sayı alanı boş.");
                return;
            }

            else

            {

                int sayi1, sayi2, toplam;

                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                toplam = sayi1 * sayi2;

                label3.Text = toplam.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("1. Sayı alanı boş.");
                return;
            }

            else if (textBox2.Text == "")
            {
                MessageBox.Show("2. Sayı alanı boş..");
                return;
            }

            else

            {

                int sayi1, sayi2, toplam;

                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                toplam = sayi1 / sayi2;

                label3.Text = toplam.ToString();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }

                if (item is Label myLabel)
                {
                    label3.Text = "";
                }
            }

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}