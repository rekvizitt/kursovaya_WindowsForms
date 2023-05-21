namespace kursovaya
{
    public partial class Zastavka : Form
    {
        public Zastavka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log_in loginForm = new Log_in();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

    }
}