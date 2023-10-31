namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int count = 0, average = 0, sum = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                int height = int.Parse(textBox1.Text);
                count++;
                if (count > 20) {
                    MessageBox.Show("Max reached");
                }
                else{
                    listBox1.Items.Add(height);
                    textBox1.Text = "";
                    sum += height;
                    average = sum / count; 
                    textBox2.Text = average.ToString();
                }
            }
            catch (Exception er) { 
                MessageBox.Show(er.Message);
            }
        }
    }
}
