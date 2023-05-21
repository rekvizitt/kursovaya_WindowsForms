using System.Windows.Forms;

namespace kursovaya
{
    public partial class FindData : Form
    {
        public FindData()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Проверяет пустые листроки номера группы и Ф.И.О. и устанавливает errorProvider1.
        /// </summary>
        public bool errorProviderCheck()
        {
            bool isValid = true;
            // проверка пустое ли поле ComboBox1.
            if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox1, "Поле не должно быть пустым.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(comboBox1, "");
            }
            // проверка пустое ли поле TextBox1.
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Поле не должно быть пустым.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }

            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && groupBox1.Visible)
            {
                errorProvider1.SetError(groupBox1, "Выберети один из вариантов");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(groupBox1, "");
            }
            // Возвращаем значение допустимости.
            return isValid;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Ф.И.О.") 
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
        }
    }
}
