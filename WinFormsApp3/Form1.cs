namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ("Tebrikler Toplam Puan: " + " " + Convert.ToString(i) + ".");
            if (i <= 20)
            {
                i++;
            }
            else if (i > 20)
            {
                label1.Text = "Oyun Bitti";
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd  = new Random();
            button1.Left = Convert.ToInt32(rnd.Next(Size.Width - button1.Size.Width));
            button1.Top = Convert.ToInt32(rnd.Next(Size.Height - button1.Size.Height));
        }
    }
}
