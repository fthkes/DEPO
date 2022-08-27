namespace NotOrtalamaHesaplamaDeneme
{
    public partial class Form1 : Form
    {
        int not1, not2, not3;
        double ortalama;

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int x = 5;
            int y = 2*x;
            textBox5.Text = y.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = (((8 + 5) - 3) * 5) /2;
            double y = Math.Pow(x, 2);
            textBox5.Text = y.ToString();

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            not1 = Convert.ToInt32(textBox1.Text);
            not2 = Convert.ToInt32(textBox2.Text);
            not3 = Convert.ToInt32(textBox3.Text);
            ortalama = (double)(not1 + not2 + not3) / 3;
            textBox4.Text = Convert.ToString(ortalama);
            
            


        }
    }
}