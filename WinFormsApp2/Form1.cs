namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Random rm = nownColor Randow();
            //int r = rm.Next(2, 255);
            //int g = rm.Next(2, 255);
            //int b = rm.Next(2, 255);

            //this.BackColor = Color.FromArgb(r, g, b);
            //this.Text = r.ToString() + "," + g,ToString() + "," + b.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "มหาวิทยาลัยราชภัฎอุดรธานี")
            {
                label1.Text = "Udonthani Rajabhat University";
            }
            else
            {
                label1.Text = "มหาวิทยาลัยราชภัฎอุดรธานี";
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightYellow;
            label1.Text = "Udonthani Rajabhat University";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            label1.Text = "มหาวิทยาลัยราชภัฎอุดรธานี";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            Random rm = new Random();
            int r = rm.Next(2, 255);
            int g = rm.Next(2, 255);
            int b = rm.Next(2, 255);

            this.BackColor = Color.FromArgb(r, g, b);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox1.
            textBox1.Text = "";
        }
    }
}