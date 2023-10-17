namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int Fibo(int num) {
            if (num <= 2)
            {
                return 1;
            }
            else {
                return Fibo(num - 1) + Fibo(num - 2);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int input_num = int.Parse(textBox1.Text);
                int res = Fibo(input_num);
                MessageBox.Show(res.ToString());
            }
            catch(Exception ex) {
                MessageBox.Show("Ivalid use");
            }

        }
    }
}