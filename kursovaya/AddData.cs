namespace kursovaya
{
    public partial class AddData : Form
    {
        public AddData()
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
            int value;
            bool isValid = true;
            // проверка пустое ли поле TextBox1.
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Поле не должно быть пустым.");
                isValid = false;
            }
            // проверка поля TextBox на наличие символов-небукв
            else if (!textBox1.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                errorProvider1.SetError(textBox1, "Поле должно содержать только буквы.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
            //
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                errorProvider1.SetError(maskedTextBox1, "Поле не должно быть пустым.");
                isValid = false;
            }
            else if (maskedTextBox1.Text.Length != 6)
            {
                errorProvider1.SetError(maskedTextBox1, "Поле должно содержать 6 символов");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(maskedTextBox1, "");
            }

            // Проверить каждое текстовое поле
            if (!int.TryParse(textBox2.Text, out value) || value < 1 || value > 10)
            {
                errorProvider1.SetError(textBox2, "Введите целое число от 1 до 10");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }

            if (!int.TryParse(textBox3.Text, out value) || value < 1 || value > 10)
            {
                errorProvider1.SetError(textBox3, "Введите целое число от 1 до 10");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
            }


            if (!int.TryParse(textBox4.Text, out value) || value < 1 || value > 10)
            {
                errorProvider1.SetError(textBox4, "Введите целое число от 1 до 10");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(textBox4, "");
            }

            if (!int.TryParse(textBox5.Text, out value) || value < 1 || value > 10)
            {
                errorProvider1.SetError(textBox5, "Введите целое число от 1 до 10");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(textBox5, "");
            }

            if (!int.TryParse(textBox6.Text, out value) || value < 1 || value > 10)
            {
                errorProvider1.SetError(textBox6, "Введите целое число от 1 до 10");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(textBox6, "");
            }
            // Если есть неверные значения - вывести сообщение об ошибке
            if (!isValid)
            {
                MessageBox.Show("Проверьте правильность заполнения формы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Возвращаем значение допустимости.
            return isValid;
        }
    }
}
