namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                int sum = 0, counter = 0, avg;
                int input_num = int.Parse(textBox1.Text);

                while (counter < 20) {
                
                    listBox1.Items.Add(input_num);
                    sum += input_num;
                    counter++;
                    avg = sum / counter;
                    textBox2.Text = avg.ToString();
                    textBox1.Text = "";

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}