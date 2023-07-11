using System.Linq.Expressions;

namespace Windows_Calculator
{
    public partial class Form1 : Form
    {
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || label1.Text == null)
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text = label1.Text + "1";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Show();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MessageBox.Show(" The maximum digit is 19, it does not appear after 19. How to use? Click any numbers then choose your operation then click another number and click equal button. If you want to make more operations with your solution just click an operation then click another number and click equal button.  Thx for using.. ");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || label1.Text == null)
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text = label1.Text + "9";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || label1.Text == null)
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text = label1.Text + "2";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || label1.Text == null)
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text = label1.Text + "3";
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || label1.Text == null)
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text = label1.Text + "4";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || label1.Text == null)
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text = label1.Text + "5";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || label1.Text == null)
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text = label1.Text + "6";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || label1.Text == null)
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text = label1.Text + "7";
            }



        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || label1.Text == null)
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text = label1.Text + "8";
            }

        }

        private void button0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + ",";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

            label2.Text = label1.Text;
            label3.Text = "+";
            label1.Text = "0";
            Operation = "+";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(label1.Text);
            double b = Convert.ToDouble(label2.Text);
            if (Operation == "+")
            {
                double c = a + b;
                label1.Text = c.ToString();
            }
            else if (Operation == "-")
            {
                double c = b - a;
                label1.Text = c.ToString();
            }
            else if (Operation == "*")
            {
                double c = a * b;
                label1.Text = c.ToString("0.00000");
            }
            else if (Operation == "/")
            {
                double c = b / a;
                label1.Text = c.ToString("0.00000");
            }
            else if (Operation == "X^n")
            {
                double pow = Math.Pow(Convert.ToDouble(label2.Text), Convert.ToDouble(label1.Text));
                label1.Text = pow.ToString("0.00000");
            }
            else if (Operation == "%")
            {
                double mod = Convert.ToDouble(label2.Text);
                double mod2 = Convert.ToDouble(label1.Text);
                label1.Text = (mod % mod2).ToString("0.00000");

            }
            else
            {
                MessageBox.Show("Unknown command...Crash");
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {

            label1.Text = null;

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            label2.Text = label1.Text;
            label3.Text = "-";
            label1.Text = "0";
            Operation = "-";
        }

        private void buttonMultpctn_Click(object sender, EventArgs e)
        {
            label2.Text = label1.Text;
            label3.Text = "*";
            label1.Text = "0";
            Operation = "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            label2.Text = label1.Text;
            label3.Text = "/";
            label1.Text = "0";
            Operation = "/";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1divideX_Click(object sender, EventArgs e)
        {
            label2.Text = label1.Text;
            label3.Text = "Xⁿ";
            label1.Text = "0";
            Operation = "X^n";

        }

        private void buttonNegate_Click(object sender, EventArgs e)
        {
            double ccc = Convert.ToDouble(label1.Text);
            label1.Text = (ccc * -1).ToString();
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double www = Convert.ToDouble(label1.Text);
            label2.Text = "sqrt(" + label1.Text + ")";
            label1.Text = Convert.ToString(Math.Sqrt(www));
        }



        private void buttonMod_Click(object sender, EventArgs e)
        {
            label2.Text = label1.Text;
            label3.Text = "%";
            label1.Text = "0";
            Operation = "%";
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            string labelText = label1.Text; // Label kontrolündeki metni alın  //THEESE CODES WRITTEN BY CHATGPT
            if (!string.IsNullOrEmpty(labelText)) // Metnin boş olmadığından emin olun
            {
                labelText = labelText.Substring(0, labelText.Length - 1); // Son karakteri kaldırın
                label1.Text = labelText; // Yeni metni Label kontrolüne atayın
            }
        }
        

        //private void label1_TextChanged(object sender, EventArgs e)
        //{
        //    int maxLength = 12; // En fazla 10 karaktere izin verilecek                  //THEESE CODES WRITTEN BY CHATGPT

        //    if (label1.Text.Length > maxLength)
        //    {
        //        label1.Text = label1.Text.Substring(0, maxLength)+"..."; // Belirtilen karakter sayısına kadar olan kısmı alır
        //    }
        //}
    }
}