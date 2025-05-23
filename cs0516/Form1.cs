namespace cs0516
{
    public partial class Form1 : Form
    {
        int vx = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("‚±‚ñ‚É‚¿‚Í");
            MessageBox.Show(100.ToString());
            MessageBox.Show($"{100}");
            MessageBox.Show($"label1.Top={label1.Top}");
            MessageBox.Show(3.14f.ToString());
            MessageBox.Show($"{3.14}");

            MessageBox.Show(1 + 1.ToString());//11
            MessageBox.Show((1 + 1).ToString());//2
            MessageBox.Show($"{1 + 1}");//2

            MessageBox.Show((1.23f * 1.23f).ToString());
            MessageBox.Show($"{1.23f * 2.34f}");

            MessageBox.Show("1" + "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            a += 5;
            MessageBox.Show($"{a}");
            a -= 5;
            MessageBox.Show($"{a}");
            a *= 5;
            MessageBox.Show($"{a}");
            a /= 5;
            MessageBox.Show($"{a}");
            a %= 5;
            MessageBox.Show($"{a}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
            label1.Text = "Hello";
            MessageBox.Show($"‚±‚ñ‚É‚¿‚Í{textBox1.Text}‚³‚ñ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left--;
            button7.Left+=vx;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            float fw;
            string str = "123";
            bool bl;

            int b = 10;
            float fw2 = -10.5f;
            string str2 = "‚±‚ñ‚É‚¿‚Í";
            bool bl2 = true;

            b = (int)fw2;
            a = int.Parse(str);
            fw = b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int vx = 5;
            MessageBox.Show($"{vx}");
            vx = 10;
            MessageBox.Show($"{vx}");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{vx}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            vx =-vx;
            //MessageBox.Show($"{vx}");
        }
    }
}
