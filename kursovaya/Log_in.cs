namespace kursovaya
{
    /// <summary>
    /// Структура User содержит поля Login, Password и Role.
    /// </summary>
    public struct User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }

    public partial class Log_in : Form
    {

        // переменная путь к файлу с данными о пользователях
        private string usersFile = Path.Combine(Application.StartupPath, "usersDataBase.csv");

        public Log_in()
        {
            InitializeComponent();

            // проверка, существует ли файл с данными пользователей
            if (!File.Exists(usersFile))
            {
                // создание файла с учетными записями и запись учетных данных администратора
                CreateDefaultUsersFile();
            }
        }

        /// <summary>
        /// Кнопка Log in на форме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // проверяем ввод логина
            errorProviderCheck();

            // проверяем, что textBox1 и textBox2 не пустые
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                // поиск пользователя по логину и паролю в файле
                User user = userSearch();

                // очистка textBox1 и textBox2 от символов
                textBox1.Clear();
                textBox2.Clear();

                if (user.Login == null)
                {
                    // Выводим сообщение пользователю об успешной сортировке по задолженностям
                    MessageBox.Show("Пользователь не найден.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // Вызов метода, который выполняет действия после проверки роли пользователя
                    checkRole(user);
                }
            }


        }

        /// <summary>
        /// Проверка ввода логина и пароля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void errorProviderCheck()
        {
            // Проверяем ввод логина
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Введите логин");
            }
            else
            {
                errorProvider1.Clear();
            }

            // Проверяем ввод пароля
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Введите пароль");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        /// <summary>
        /// поиск пользователя по логину и паролю в файле.
        /// </summary>
        private User userSearch()
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            User user = new User();

            using (StreamReader usersReader = new StreamReader(usersFile))
            {
                while (!usersReader.EndOfStream)
                {
                    string line = usersReader.ReadLine();
                    string[] usersData = line.Split(',');

                    // проверка сходятся ли введенные пользователем данные с
                    // данными в файле.
                    if (usersData[0] == login && usersData[1] == password)
                    {
                        int role = int.Parse(usersData[2]);
                        user = new User { Login = login, Password = password, Role = role };
                        break;
                    }
                }
            }
            return user;
        }

        /// <summary>
        /// Проверка роли пользователя и последующие действия (открытие нужной формы либо вывод
        /// текста "Пользователь не найден").
        /// </summary>
        private void checkRole(User user)
        {
            if (user.Role == 1)
            {
                // авторизация администратора
                // открываем форму для администратора
                AdminPanel adminPanel = new AdminPanel();
                this.Hide();
                adminPanel.ShowDialog();
                this.Close();
            }
            else if (user.Role == 0)
            {
                // авторизация пользователя
                userPanel userPanel = new userPanel();
                this.Hide();
                userPanel.ShowDialog();
                this.Close();
            }
        }

        /// <summary>
        /// Создание файла с учетными записями и запись учетных данных администратора.
        /// </summary>
        private void CreateDefaultUsersFile()
        {
            try
            {
                // создание файла с учетными записями пользователей (только администратор)
                using (FileStream usersReader = new FileStream(usersFile, FileMode.CreateNew)) { }
                using (StreamWriter usersWriter = new StreamWriter(usersFile))
                {
                    // вписываем в файл строчку с данными для входа (как администратор)
                    usersWriter.WriteLine("admin,admin,1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка создания файла с учетными записями: " + ex.Message);
            }
        }

        /// <summary>
        /// По нажатию на CheckBox возле поля "password" символы на поле становятся видимыми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }

}