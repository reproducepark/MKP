namespace MKP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Killer.Func();
            MessageBox.Show("MK executed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nosleep.ToggleNoSleep(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
