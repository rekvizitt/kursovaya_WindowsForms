namespace kursovaya
{
    public partial class addUserData : Form
    {
        public addUserData()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Проверяет пустые ли строки номера группы и Ф.И.О. и устанавливает errorProvider1.
        /// </summary>
        public bool errorProviderCheck()
        {
            int value;
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Поле не должно быть пустым.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Поле не должно быть пустым.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                errorProvider1.SetError(groupBox1, "Выберите роль.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(groupBox1, "");
            }

            // Если есть неверные значения - вывести сообщение об ошибке
            if (!isValid)
            {
                MessageBox.Show("Проверьте правильность заполнения формы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

    }
}
