namespace kursovaya
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void вернутьсяНаГлавноеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            // При открытии формы текст выделен, с помощью вызова методов убирается выделение текста
            textBox1.Select(0, 0);
            textBox1.ScrollToCaret();
        }
    }
}