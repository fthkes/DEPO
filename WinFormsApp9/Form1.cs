namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        int not1, not2, not3, not4, not5, not6;
        double ortalama;

        private void button2_Click(object sender, EventArgs e)
        {
            not4 = Convert.ToInt32(textBox6.Text);
            not5 = Convert.ToInt32(textBox7.Text);
            not6 = Convert.ToInt32(textBox8.Text);

            ortalama = (double)(not4 + not5 + not6) / 3;
            textBox5.Text = Convert.ToString(ortalama);
        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            not1 = Convert.ToInt32 (textBox1.Text);
            not2 = Convert.ToInt32 (textBox2.Text);
            not3 = Convert.ToInt32 (textBox3.Text);

            ortalama = (double) ( not1 + not2 + not3 )/3;
            textBox4.Text = Convert.ToString(ortalama);


         

 
        }
    }
}