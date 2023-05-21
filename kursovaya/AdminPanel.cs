using OfficeOpenXml;
using System.ComponentModel;
using System.Data;

namespace kursovaya
{
    public partial class AdminPanel : Form
    {
        private string fileName;
        private string usersFile = Path.Combine(Application.StartupPath, "usersDataBase.csv");
        private string lastOpenedFileName;
        public AdminPanel()
        {
            InitializeComponent();
            CreateDataTable();
            CreateDataTable_2();

        }

        /// <summary>
        /// Отключает всем новым колонкам в dataGridView1 возможность сортировки с помощью
        /// нажатия на название колонки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        /// <summary>
        /// Создание столбцов таблицы dataTable. (для DataGridView1)
        /// </summary>
        private void CreateDataTable()
        {
            // Создаем таблицу для хранения данных
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Номер_группы");
            dataTable.Columns.Add("Ф.И.О.");
            for (int i = 1; i <= 5; i++)
            {
                dataTable.Columns.Add("Зачет_" + i);
            }
            for (int i = 1; i <= 5; i++)
            {
                dataTable.Columns.Add("Отметка_" + i);
            }

            // Добавляем таблицу к DataGridView
            dataGridView1.DataSource = dataTable;
        }

        /// <summary>
        /// Создание столбцов таблицы dataTable. (для DataGridView2)
        /// </summary>
        private void CreateDataTable_2()
        {
            // Создаем таблицу для хранения данных
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Логин");
            dataTable.Columns.Add("Пароль");
            dataTable.Columns.Add("Роль");

            // Добавляем таблицу к DataGridView
            dataGridView2.DataSource = dataTable;
        }

        /// <summary>
        /// Обновляем данные таблицы (добавляем новые строки в dataGridView1).
        /// </summary>
        private void RefreshTable()
        {
            RemoveDebtsColumn();
            RemoveAverageMarkColumn();
            MakeVisibleTable1();
            // Проверяем, что файл существует
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException($"Файл {fileName} не найден.");
            }

            // Считываем данные из файла
            string[] lines = File.ReadAllLines(fileName);

            // Получаем таблицу данных из DataGridView
            DataTable dataTable = (DataTable)dataGridView1.DataSource;

            //// Очищаем таблицу от предыдущих данных
            dataTable.Rows.Clear();

            // Добавляем новые строки в таблицу
            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                // Создаем новую строку
                DataRow row = dataTable.NewRow();

                // Заполняем значениями из файла
                for (int i = 0; i < values.Length; i++)
                {
                    row[i] = values[i];
                }

                // Добавляем строку в таблицу
                dataTable.Rows.Add(row);
            }
        }

        /// <summary>
        /// Обновляем данные таблицы (добавляем новые строки в dataGridView2).
        /// </summary>
        private void RefreshTable_2()
        {
            RemoveDebtsColumn();
            RemoveAverageMarkColumn();

            MakeVisibleTable2();

            // Проверяем, что файл существует
            if (!File.Exists(usersFile))
            {
                throw new FileNotFoundException($"Файл {usersFile} не найден.");
            }

            // Считываем данные из файла
            string[] lines = File.ReadAllLines(usersFile);

            // Получаем таблицу данных из DataGridView
            DataTable dataTable = (DataTable)dataGridView2.DataSource;

            //// Очищаем таблицу от предыдущих данных
            dataTable.Rows.Clear();

            // Добавляем новые строки в таблицу
            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                // Создаем новую строку
                DataRow row = dataTable.NewRow();

                // Заполняем значениями из файла
                for (int i = 0; i < values.Length; i++)
                {
                    row[i] = values[i];
                }

                // Добавляем строку в таблицу
                dataTable.Rows.Add(row);
            }
        }

        /// <summary>
        /// Делает таблицу DataGridView1 видимой, а DataGridView2 - невидимой.
        /// </summary>
        private void MakeVisibleTable1()
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
        }

        /// <summary>
        /// Делает таблицу DataGridView2 видимой, а DataGridView1 - невидимой.
        /// </summary>
        private void MakeVisibleTable2()
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
        }


        /// <summary>
        /// Удаляет из таблицы колонку "Задолженность", если она существует
        /// (эта колонка используется в индивидуальном задании).
        /// </summary>
        private void RemoveDebtsColumn()
        {
            // Ищем колонку "Задолженность" и удаляем ее из DataGridView
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.HeaderText == "Задолженность")
                {
                    dataGridView1.Columns.Remove(column);
                    break; // прерываем цикл, так как колонку уже удалили
                }
            }
        }

        /// <summary>
        /// Удаляет из таблицы колонку "Задолженность", если она существует
        /// (эта колонка используется в индивидуальном задании).
        /// </summary>
        private void RemoveAverageMarkColumn()
        {
            // Ищем колонку "Средний балл" и удаляем ее из DataGridView
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.HeaderText == "Средний балл")
                {
                    dataGridView1.Columns.Remove(column);
                    break; // прерываем цикл, так как колонку уже удалили
                }
            }
        }

        /// <summary>
        /// Очищаем строчки таблицы.
        /// </summary>
        private void ClearRows()
        {
            // Очищаем строки таблицы, если они не равны null
            if (dataGridView1 != null && dataGridView1.Rows != null && dataGridView1.Rows.Count > 0)
            {
                for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                {
                    if (!dataGridView1.Rows[i].IsNewRow)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
        }

        /// <summary>
        /// Создание файла с данными о студентах.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void создатьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файл данных (*.dat)|*.dat";
            saveFileDialog.Title = "Создание";
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                работаСДаннымиToolStripMenuItem.Enabled = true;
                MakeVisibleTable1();

                // Очищаем строки таблицы после создания файла.
                ClearRows();

                // Получаем имя файла от пользователя
                fileName = saveFileDialog.FileName;
                using (FileStream file = new FileStream(fileName, FileMode.Create))
                {
                    lastOpenedFileName = fileName; // сохраняем имя файла
                }
                MessageBox.Show("Файл успешно создан.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Создание файла отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Открытие файла с данными о студентах.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Получаем имя файла от пользователя
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файл данных (*.dat)|*.dat";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                работаСДаннымиToolStripMenuItem.Enabled = true;
                MakeVisibleTable1();

                // Очищаем строки таблицы после открытия файла.
                ClearRows();

                fileName = openFileDialog.FileName;
                lastOpenedFileName = fileName; // сохраняем имя файла
                using (StreamReader file = new StreamReader(fileName))
                {
                    // тут доделать темку со структурой 
                }
                RefreshTable();
                MessageBox.Show("Файл успешно открыт.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Открытие файла отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Удаление файла с данными о студентах.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void удалитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файл данных (*.dat)|*.dat";
            openFileDialog.Title = "Удаление";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем имя выбранного файла
                string fileName = openFileDialog.FileName;

                // Запрашиваем подтверждение удаления
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить файл?", "Подтверждение удаления",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Проверяем, совпадает ли имя файла с именем последнего открытого файла
                    if (fileName == lastOpenedFileName)
                    {
                        // Очищаем строчки таблицы.
                        ClearRows();
                        работаСДаннымиToolStripMenuItem.Enabled = false;
                    }
                    // Удаляем файл
                    File.Delete(fileName);
                    // Выводим сообщение об успешном удалении файла
                    MessageBox.Show("Файл успешно удален.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    // Выводим сообщение об отмене удаления файла
                    MessageBox.Show("Удаление файла отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                // Выводим сообщение об отмене удаления файла
                MessageBox.Show("Удаление файла отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        /// <summary>
        /// Проверяет, существует ли такая запись (информация о студентах)
        /// </summary>
        /// <param name="groupNumber"></param>
        /// <param name="studentName"></param>
        /// <returns></returns>
        private bool IsRecordExists(string groupNumber, string studentName)
        {
            using (StreamReader fileReader = new StreamReader(fileName))
            {
                string line;

                while ((line = fileReader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');

                    if (string.Equals(fields[0], groupNumber, StringComparison.OrdinalIgnoreCase) &&
                        string.Equals(fields[1], studentName, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Проверяет, существует ли такая запись, метод используется во время редактирования записи.
        /// </summary>
        /// <param name="oldGroupNumber"></param>
        /// <param name="oldStudentName"></param>
        /// <param name="newGroupNumber"></param>
        /// <param name="newStudentName"></param>
        /// <returns></returns>
        private bool IsRecordExists(string oldGroupNumber, string oldStudentName, string newGroupNumber, string newStudentName)
        {
            // Если номер группы и Ф.И.О. не изменились, то запись точно не существует
            if (oldGroupNumber == newGroupNumber && oldStudentName == newStudentName)
            {
                return false;
            }

            using (StreamReader fileReader = new StreamReader(fileName))
            {
                string line;

                while ((line = fileReader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');

                    if (string.Equals(fields[0], newGroupNumber, StringComparison.OrdinalIgnoreCase) &&
                        string.Equals(fields[1], newStudentName, StringComparison.OrdinalIgnoreCase))
                    {
                        // Если найдена запись с таким же номером группы и Ф.И.О., но она не совпадает по строке целиком с редактируемой записью,
                        // значит, это другая запись. Возвращаем true.
                        if (line != $"{oldGroupNumber},{oldStudentName},{fields[2]},{fields[3]},{fields[4]},{fields[5]},{fields[6]},{fields[7]},{fields[8]},{fields[9]},{fields[10]},{fields[11]}")
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }


        /// <summary>
        /// Проверяет, существует ли такая учетная запись
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private bool IsUserExists(string login)
        {
            using (StreamReader fileReader = new StreamReader(usersFile))
            {
                string line;

                while ((line = fileReader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');

                    if (fields[0] == login)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        /// <summary>
        /// Проверяет, существует ли такая учетная запись, используется во время редактирования учетной записи.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private bool IsUserExists(string oldLogin, string newLogin)
        {
            using (StreamReader fileReader = new StreamReader(usersFile))
            {
                string line;

                while ((line = fileReader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');

                    if (fields[0] == newLogin)
                    {
                        // Если найдена запись с таким же логином., но она не совпадает по строке целиком с редактируемой записью,
                        // значит, это другая запись. Возвращаем true.
                        if (line != $"{oldLogin},{fields[1]},{fields[2]}")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }



        /// <summary>
        /// Просмотр всех данных о студентах из файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void просмотрВсехДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeVisibleTable1();

            // Обновляем таблицу dataGridView1
            RefreshTable();

            // Выводим сообщение пользователю о том, что таблица успешно обновлена
            MessageBox.Show("Таблица успешно обновлена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// Добавление новой записи в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void добавитьНовуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы form4
            AddData addData = new AddData();
            // Меняем текст form4 на соответствующий
            addData.Text = "Добавить запись";
            bool isValid = false; // Флаг, указывающий, что значения были введены правильно

            while (!isValid)
            {
                DialogResult result = addData.ShowDialog(); // Отображаем форму AddData

                if (result == DialogResult.OK && addData.errorProviderCheck())
                {
                    isValid = true;

                    string groupNumber = addData.maskedTextBox1.Text;
                    string studentName = addData.textBox1.Text;
                    bool[] grades = { addData.checkBox1.Checked, addData.checkBox2.Checked, addData.checkBox3.Checked, addData.checkBox4.Checked, addData.checkBox5.Checked };
                    string[] marks = { addData.textBox2.Text, addData.textBox3.Text, addData.textBox4.Text, addData.textBox5.Text, addData.textBox6.Text };

                    // Проверяем, существует ли уже запись с такими же данными
                    if (IsRecordExists(groupNumber, studentName))
                    {
                        MessageBox.Show("Запись с такими данными уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isValid = false;
                    }
                    else
                    {
                        // Запрашиваем подтверждение удаления
                        DialogResult addDataResult = MessageBox.Show("Вы действительно хотите добавить запись?", "Подтверждение добавления записи",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (addDataResult == DialogResult.Yes)
                        {
                            using (StreamWriter fileWriter = new StreamWriter(fileName, true))
                            {
                                fileWriter.WriteLine($"{groupNumber},{studentName},{string.Join(",", grades)},{string.Join(",", marks)}");
                            }
                            MakeVisibleTable1();
                            RefreshTable();
                            MessageBox.Show("Запись успешно добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (addDataResult == DialogResult.No)
                        {
                            // Выводим сообщение об отмене добавления записи
                            MessageBox.Show("Добавление записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Закрытие формы без выбора записи
                            return;
                        }
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    // Выводим сообщение об отмене добавления записи
                    MessageBox.Show("Добавление записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Закрытие формы без выбора записи
                    return;
                }
            }
        }

        /// <summary>
        /// Обработчик события "Редактировать запись". Открывает форму, позволяющую выбрать
        /// запись для редактирования. После выбора открывается форма для редактирования данных,
        /// и введенные значения сохраняются в файле.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void редактироватьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем форму для выбора строки для редактирования
            DeleteData chooseData = new DeleteData();
            // Меняем текст label1 на соответствующий.
            chooseData.label1.Text = "Выберите запись, которую хотите отредактировать";
            // Меняем текст chooseData(формы) на соответствующий
            chooseData.Text = "Редактирование записи";

            // Получаем таблицу данных из DataGridView1
            DataTable dataTable = (DataTable)dataGridView1.DataSource;

            // Заполняем ComboBox на форме значениями из файла
            foreach (DataRow row in dataTable.Rows)
            {
                chooseData.comboBox1.Items.Add($"{row[0]},{row[1]},{row[2]},{row[3]},{row[4]},{row[5]},{row[6]}," +
                  $"{row[7]},{row[8]},{row[9]},{row[10]},{row[11]}");
            }

            // Создаем форму для редактирования выбранной ранее строки
            AddData editData = new AddData();

            // Меняем текст addDataForm на соответствующий
            editData.Text = "Редактирование записи";

            // Ожидаем пока пользователь выберет запись или закроет окно
            DialogResult selectionResult;
            do
            {
                // Показываем форму для выбора записи и ждем результат
                selectionResult = chooseData.ShowDialog();
                // Если пользователь не выбрал запись, выводим сообщение об ошибке  
                if (chooseData.comboBox1.SelectedIndex == -1 && selectionResult == DialogResult.OK)
                {
                    MessageBox.Show("Выберите запись для редактирования.", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (selectionResult == DialogResult.OK && chooseData.comboBox1.SelectedIndex == -1);

            if (selectionResult == DialogResult.OK)
            {
                // Получаем выбранную пользователем запись
                string selectedAccount = chooseData.comboBox1.SelectedItem.ToString();

                //Присваиваем элементам на форме значения выбранной строки
                string[] data = selectedAccount.Split(',');

                editData.maskedTextBox1.Text = data[0];
                editData.textBox1.Text = data[1];

                for (int i = 2; i < 7; i++)
                {
                    ((CheckBox)editData.Controls.Find($"checkBox{i - 1}", true)[0]).Checked = bool.Parse(data[i]);
                }

                for (int i = 7; i < 12; i++)
                {
                    ((TextBox)editData.Controls.Find($"textBox{i - 5}", true)[0]).Text = data[i];
                }

                // Определяемся со строкой которую будем редактировать
                string oldText = selectedAccount;
                bool isValid = false; // Флаг, указывающий, что значения были введены правильно
                while (!isValid)
                {
                    DialogResult result = editData.ShowDialog(); // Отображаем форму editData
                    if (result == DialogResult.OK && editData.errorProviderCheck())
                    {
                        isValid = true;

                        // Проверяем, существует ли уже запись с такими же данными
                        if (IsRecordExists(data[0], data[1], editData.maskedTextBox1.Text, editData.textBox1.Text))
                        {
                            MessageBox.Show("Запись с такими данными уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isValid = false;
                        }
                        else
                        {
                            string[] newData = {
                          editData.maskedTextBox1.Text,
                          editData.textBox1.Text,
                          editData.checkBox1.Checked.ToString(),
                          editData.checkBox2.Checked.ToString(),
                          editData.checkBox3.Checked.ToString(),
                          editData.checkBox4.Checked.ToString(),
                          editData.checkBox5.Checked.ToString(),
                          editData.textBox2.Text,
                          editData.textBox3.Text,
                          editData.textBox4.Text,
                          editData.textBox5.Text,
                          editData.textBox6.Text
                        };
                            // Запрашиваем подтверждение редактирования
                            DialogResult addDataResult = MessageBox.Show("Вы действительно хотите редактировать запись?", "Подтверждение редактирования записи",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (addDataResult == DialogResult.Yes)
                            {
                                //// создаем строку которую будем заменять на старую
                                string newText = string.Join(",", newData);

                                string text = File.ReadAllText(fileName);
                                text = text.Replace(oldText, newText);
                                File.WriteAllText(fileName, text);

                                MakeVisibleTable1();
                                // Обновляем таблицу DataGridView1 с учетом новых данных
                                RefreshTable();
                            }
                            else if (addDataResult == DialogResult.No)
                            {
                                // Выводим сообщение об отмене редактирования записи
                                MessageBox.Show("Редактирование записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Закрытие формы без выбора записи
                                return;
                            }

                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // Выводим сообщение об отмене редактирования записи
                        MessageBox.Show("Редактирование записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Закрытие формы без выбора записи
                        return;
                    }
                }

            }
            else if (selectionResult == DialogResult.Cancel)
            {
                // Выводим сообщение об отмене редактирования записи
                MessageBox.Show("Редактирование записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Закрытие формы без выбора записи
                return;
            }
        }

        /// <summary>
        /// Удаляет запись из файла, после чего появляется новая таблица с обновленными данными.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем форму для выбора строки для удаления
            DeleteData deleteData = new DeleteData();

            // Получаем таблицу данных из DataGridView1
            DataTable dataTable = (DataTable)dataGridView1.DataSource;


            // Заполняем ComboBox на форме значениями из файла
            foreach (DataRow row in dataTable.Rows)
            {
                deleteData.comboBox1.Items.Add($"{row[0]},{row[1]},{row[2]},{row[3]},{row[4]},{row[5]},{row[6]}," +
                  $"{row[7]},{row[8]},{row[9]},{row[10]},{row[11]}");
            }

            // Ожидаем пока пользователь выберет запись или закроет окно
            DialogResult selectionResult;
            do
            {
                // Показываем форму для выбора записи и ждем результат
                selectionResult = deleteData.ShowDialog();
                // Если пользователь не выбрал запись, выводим сообщение об ошибке  
                if (deleteData.comboBox1.SelectedIndex == -1 && selectionResult == DialogResult.OK)
                {
                    MessageBox.Show("Выберите запись для удаления.", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (selectionResult == DialogResult.OK && deleteData.comboBox1.SelectedIndex == -1);

            if (selectionResult == DialogResult.OK)
            {
                // Запрашиваем подтверждение удаления
                DialogResult addDataResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (addDataResult == DialogResult.Yes)
                {
                    // Открываем временный файл на запись
                    string tempFileName = Path.GetTempFileName();
                    using (StreamWriter writer = new StreamWriter(tempFileName))
                    {
                        // Открываем исходный файл на чтение
                        using (StreamReader reader = new StreamReader(fileName))
                        {
                            string line;
                            string selectedItem = deleteData.comboBox1.SelectedItem.ToString();
                            while ((line = reader.ReadLine()) != null)
                            {
                                // Разделяем строку по запятым и проверяем, является ли она удаляемой
                                string[] lineItems = line.Split(',');
                                if (!selectedItem.Contains(lineItems[0]) || !selectedItem.Contains(lineItems[1]))
                                {
                                    // Записываем строку во временный файл, если она не является удаляемой
                                    writer.WriteLine(line);
                                }
                            }
                        }
                    }
                    // Выводим сообщение об успешном удалении записи
                    MessageBox.Show("Запись успешно удалена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Удаляем исходный файл
                    File.Delete(fileName);
                    // Переименовываем временный файл в исходное имя
                    File.Move(tempFileName, fileName);
                    // Делаем видимым dataGridView1
                    MakeVisibleTable1();
                    // Обновляем таблицу dataGridView1
                    RefreshTable();
                }
                else if (addDataResult == DialogResult.No)
                {
                    // Выводим сообщение об отмене удаления записи
                    MessageBox.Show("Удаление записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Закрытие формы без выбора записи
                    return;
                }
            }
            else
            {
                // Выводим сообщение об отмене удалении записи
                MessageBox.Show("Удаление записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }


        /// <summary>
        /// Просматривает все учетные записи (UsersData).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void просмотрВсехУчЗаписейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Делает видимой DataGridView2
            MakeVisibleTable2();

            // Обновляем таблицу dataGridView2
            RefreshTable_2();

            // Выводим сообщение пользователю о том, что таблица успешно обновлена
            MessageBox.Show("Таблица успешно обновлена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Добавляет в файл (для авторизации) новую учетную запись.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void добавитьНовуюУчЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы addUserDataForm
            addUserData addUserData = new addUserData();

            // Меняем текст label1 на соответствующий.
            addUserData.label1.Text = "Добавить учетную запись";
            // Меняем текст addUserData на соответствующий
            addUserData.Text = "Добавление учётной записи";

            bool isValid = false; // Флаг, указывающий, что значения были введены правильно

            while (!isValid)
            {
                DialogResult result = addUserData.ShowDialog();
                if (result == DialogResult.OK && addUserData.errorProviderCheck())
                {
                    isValid = true;
                    string login = addUserData.textBox1.Text;
                    string password = addUserData.textBox2.Text;
                    string role;
                    if (addUserData.radioButton1.Checked)
                    {
                        role = "0";
                    }
                    else
                    {
                        role = "1";
                    }
                    if (IsUserExists(login))
                    {
                        MessageBox.Show("Учетная запись с такими данными уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isValid = false;
                    }
                    else
                    {
                        // Запрашиваем подтверждение добавления
                        DialogResult addUsersDataResult = MessageBox.Show("Вы действительно хотите добавить учетную запись?", "Подтверждение добавления учетной записи",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (addUsersDataResult == DialogResult.Yes)
                        {
                            using (StreamWriter usersWriter = new StreamWriter(usersFile, true))
                            {
                                // Добавляем учетную запись в файл
                                usersWriter.WriteLine($"{login},{password},{role}");
                            }
                            MakeVisibleTable2();

                            // Обновляем таблицу dataGridView2
                            RefreshTable_2();

                            // Выводим сообщение об успешном добавлении учетной записи
                            MessageBox.Show("Учетная запись успешно добавлена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (addUsersDataResult == DialogResult.No)
                        {
                            // Выводим сообщение об отмене добавления записи
                            MessageBox.Show("Добавление учетной записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Закрытие формы без выбора записи
                            return;
                        }
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    // Выводим сообщение об отмене добавления записи
                    MessageBox.Show("Добавление учетной записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Закрытие формы без выбора записи
                    return;
                }
            }
        }

        /// <summary>
        /// Редактирует выбранную пользователем учетную запись в файле. (UsersData)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void редактироватьУчЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Вызываем метод RefreshTable_2 и dataGridView2.Visible ,чтобы ComboBox не был пустой.
            // Если не вызвать эти методы и при этом ни разу не нажать на "просмотр всех учетных записей",
            // то ComboBox на форме будет пустой!
            RefreshTable_2();
            dataGridView2.Visible = true;

            // Создаем форму для выбора строки для редактирования
            DeleteData chooseUsersData = new DeleteData();

            // Меняем текст label1 на соответствующий.
            chooseUsersData.label1.Text = "Выберите учётную запись, которую хотите отредактировать";
            // Меняем текст editUsersDataForm на соответствующий
            chooseUsersData.Text = "Редактирование учётной записи";

            // Получаем таблицу данных из DataGridView2
            DataTable dataTable = (DataTable)dataGridView2.DataSource;

            // Заполняем ComboBox на форме значениями из файла
            foreach (DataRow row in dataTable.Rows)
            {
                chooseUsersData.comboBox1.Items.Add($"{row[0]},{row[1]},{row[2]}");
            }

            addUserData editUsersData = new addUserData();
            editUsersData.Text = "Редактирование учетной записи";
            editUsersData.label1.Text = "Введите новые данные для этой учетной записи";

            // Ожидаем пока пользователь выберет учетную запись или закроет окно
            DialogResult selectionResult;
            do
            {
                // Показываем форму для выбора учетной записи и ждем результат
                selectionResult = chooseUsersData.ShowDialog();
                // Если пользователь не выбрал учетную запись, выводим сообщение об ошибке  
                if (chooseUsersData.comboBox1.SelectedIndex == -1 && selectionResult == DialogResult.OK)
                {
                    MessageBox.Show("Выберите запись для редактирования.", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while (selectionResult == DialogResult.OK && chooseUsersData.comboBox1.SelectedIndex == -1);

            if (selectionResult == DialogResult.OK)
            {
                // Получаем выбранную пользователем учетную запись
                string selectedAccount = chooseUsersData.comboBox1.SelectedItem.ToString();

                //Присваиваем элементам на форме значения выбранной строки
                string[] data = selectedAccount.Split(',');

                editUsersData.textBox1.Text = data[0];
                editUsersData.textBox2.Text = data[1];
                if (data[2] == "0")
                {
                    editUsersData.radioButton1.Checked = true;
                }
                else
                {
                    editUsersData.radioButton2.Checked = true;
                }

                // Определяемся со строкой которую будем редактировать
                string oldText = selectedAccount;

                bool isValid = false; // Флаг, указывающий, что значения были введены правильно
                while (!isValid)
                {
                    DialogResult result = editUsersData.ShowDialog(); // Отображаем форму editUsersData
                    if (result == DialogResult.OK && editUsersData.errorProviderCheck())
                    {
                        isValid = true;
                        if (IsUserExists(data[0], editUsersData.textBox1.Text))
                        {
                            MessageBox.Show("Учетная запись с такими данными уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isValid = false;
                        }
                        else
                        {
                            string role = editUsersData.radioButton1.Checked ? "0" : "1";
                            string[] newData =
                            {
                            editUsersData.textBox1.Text,
                            editUsersData.textBox2.Text,
                            role
                        };
                            // Запрашиваем подтверждение редактирования
                            DialogResult editUsersDataResult = MessageBox.Show("Вы действительно хотите редактировать учетную запись?", "Подтверждение редактирования учетной записи",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (editUsersDataResult == DialogResult.Yes)
                            {
                                string newText = string.Join(",", newData);
                                string text = File.ReadAllText(usersFile);
                                text = text.Replace(oldText, newText);
                                File.WriteAllText(usersFile, text);
                                MakeVisibleTable2();
                                // Обновляем таблицу DataGridView2 с учетом новых данных
                                RefreshTable_2();
                                // Выводим сообщение пользователю об успешном редактировании учетной записи
                                MessageBox.Show("Учетная запись успешно изменена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (editUsersDataResult == DialogResult.No)
                            {
                                // Выводим сообщение об отмене редактирования учетной записи
                                MessageBox.Show("Редактирование учетной записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Закрытие формы без выбора записи
                                return;
                            }
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // Выводим сообщение об отмене редактирования учетной записи
                        MessageBox.Show("Редактирование учетной записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Закрытие формы без выбора учетной записи
                        return;
                    }
                }
            }
            else
            {
                // Выводим сообщение об отмене редактирования учетной записи
                MessageBox.Show("Редактирование учетной записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Закрытие формы без выбора учетной записи
                return;
            }
        }

        /// <summary>
        /// Удаляет выбранную учётную запись.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void удалениеУчЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Вызываем метод RefreshTable_2 и dataGridView2.Visible ,чтобы ComboBox не был пустой.
            // Если не вызвать эти методы и при этом ни разу не нажать на "просмотр всех учетных записей",
            // то ComboBox на форме будет пустой!
            RefreshTable_2();
            dataGridView2.Visible = true;

            // Создаем форму для выбора строки для удаления
            DeleteData deleteUsersData = new DeleteData();

            // Меняем текст label1 на соответствующий.
            deleteUsersData.label1.Text = "Выберите запись, которую хотите удалить";
            // Меняем текст form5 на соответствующий
            deleteUsersData.Text = "Удаление записи";

            // Получаем таблицу данных из DataGridView2
            DataTable dataTable = (DataTable)dataGridView2.DataSource;

            // Заполняем ComboBox на форме значениями из файла
            foreach (DataRow row in dataTable.Rows)
            {
                deleteUsersData.comboBox1.Items.Add($"{row[0]},{row[1]},{row[2]}");
            }

            // Ожидаем пока пользователь выберет запись или закроет окно
            DialogResult selectionResult;
            do
            {
                selectionResult = deleteUsersData.ShowDialog();
                if (deleteUsersData.comboBox1.SelectedIndex == -1 && selectionResult == DialogResult.OK)
                {
                    MessageBox.Show("Выберите учетную запись для удаления.", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while (selectionResult == DialogResult.OK && deleteUsersData.comboBox1.SelectedIndex == -1);

            if (selectionResult == DialogResult.OK)
            {
                // Запрашиваем подтверждение удаления
                DialogResult deleteUsersDataResult = MessageBox.Show("Вы действительно хотите удалить учетную запись?", "Подтверждение удаления учетной записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteUsersDataResult == DialogResult.Yes)
                {
                    // Открываем временный файл на запись
                    string tempFileName = Path.GetTempFileName();
                    using (StreamWriter writer = new StreamWriter(tempFileName))
                    {
                        // Открываем исходный файл на чтение
                        using (StreamReader reader = new StreamReader(usersFile))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                // текущая строку, которую мы сравниваем с выбранной пользователем для удаления записью
                                string[] lineItems = line.Split(',');
                                // значение, выбранное пользователем из выпадающего списка, которое затем разбивается на массив строк
                                string selectedItem = deleteUsersData.comboBox1.SelectedItem.ToString();
                                string[] selectedItemValues = selectedItem.Split(',');
                                //проверяет, соответствует ли текущая строка значению, выбранному пользователем для удаления.
                                //Если не соответствует, то данная строка записывается во временный файл.
                                if (lineItems[0] != selectedItemValues[0] || lineItems[1] != selectedItemValues[1])
                                {
                                    // Записываем строку во временный файл, если она не является удаляемой
                                    writer.WriteLine(line);
                                }
                            }
                        }
                    }
                    // Удаляем исходный файл
                    File.Delete(usersFile);
                    // Переименовываем временный файл в исходное имя
                    File.Move(tempFileName, usersFile);

                    MakeVisibleTable2();

                    // Обновляем таблицу dataGridView2
                    RefreshTable_2();

                    // Выводим сообщение пользователю об успешном удалении учетной записи
                    MessageBox.Show("Учетная запись успешно удалена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (deleteUsersDataResult == DialogResult.No)
                {
                    // Выводим сообщение об отмене удаления учетной записи
                    MessageBox.Show("Удаление учетной записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Закрытие формы без выбора записи
                    return;
                }
            }
            else
            {
                dataGridView2.Visible = false;

                // Выводим сообщение пользователю об отмене удаления записи
                MessageBox.Show("Удаление учетной записи отменено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        /// <summary>
        /// Получаем данные из формы findData (выбранный столбец и значение для поиска)
        /// и фильтруем результаты по выбранному столбцу и значению
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void поискДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем форму для выбора поиска данных
            FindData findData = new FindData();
            findData.groupBox1.Visible = true;

            // Ожидаем пока пользователь выберет запись или закроет окно
            DialogResult selectionResult;
            do
            {
                selectionResult = findData.ShowDialog();
                if (!findData.errorProviderCheck() && selectionResult == DialogResult.OK)
                {
                    MessageBox.Show("Выберите параметр и значение для поиска.", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while (!findData.errorProviderCheck() && selectionResult == DialogResult.OK);


            if (selectionResult == DialogResult.OK)
            {
                MakeVisibleTable1();

                // Получаем выбранный пользователем столбец и значение для поиска
                string column = findData.comboBox1.Text;
                string value = findData.textBox1.Text;

                // Читаем данные из таблицы dataGridView1
                DataTable dataTable = (DataTable)dataGridView1.DataSource;

                // Фильтруем результаты по выбранному столбцу и значению
                DataView dataView = new DataView(dataTable);

                if (column == "Ф.И.О.")
                {
                    column = "[Ф.И.О.]";
                }

                string operatorSymbol = "";
                if (findData.radioButton1.Checked)
                {
                    operatorSymbol = ">";
                }
                else if (findData.radioButton2.Checked)
                {
                    operatorSymbol = "<";
                }
                else if (findData.radioButton3.Checked)
                {
                    operatorSymbol = "=";
                }

                string filterExpression;
                if (operatorSymbol == "")
                {
                    filterExpression = $"{column} = '{value.Replace("'", "''")}'";
                }
                else
                {
                    if ((column == "Отметка_1" || column == "Отметка_2" || column == "Отметка_3" || column == "Отметка_4" || column == "Отметка_5") && (operatorSymbol == ">" || operatorSymbol == "<"))
                    {
                        int numericValue;
                        if (!int.TryParse(value, out numericValue))
                        {
                            MessageBox.Show("Значение должно быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        filterExpression = $"{column} {operatorSymbol} {numericValue}";
                    }
                    else
                    {
                        filterExpression = $"{column} {operatorSymbol} '{value.Replace("'", "''")}'";
                    }
                }

                dataView.RowFilter = filterExpression;
                DataTable results = dataView.ToTable();

                // Если в результате получен пустой DataTable, выводим MessageBox с сообщением об отсутствии результатов
                if (results.Rows.Count == 0)
                {
                    MessageBox.Show("Результаты не найдены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Обновляем dataGridView с результатами поиска
                    dataGridView1.DataSource = results;
                    MessageBox.Show($"Найдено записей: {results.Rows.Count}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Выводим сообщение пользователю об отмене поиска записи
                MessageBox.Show("Поиск записи отменен.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        /// <summary>
        /// Получаем данные из формы sortData (выбранный столбец и значение для поиска)
        /// и фильтруем таблицу по выбранному столбцу и значению
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сортировкаДанныхToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // инициализируем экземплеяр sortData
            SortData sortData = new SortData();

            // Ожидаем пока пользователь выберет запись или закроет окно
            DialogResult selectionResult;
            do
            {
                selectionResult = sortData.ShowDialog();
                if ((sortData.comboBox1.SelectedIndex == -1 || (!sortData.radioButton1.Checked && !sortData.radioButton2.Checked))
                    && selectionResult == DialogResult.OK)
                {
                    MessageBox.Show("Выберите параметр и вариант сортировки.", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while ((sortData.comboBox1.SelectedIndex == -1 || (!sortData.radioButton1.Checked && !sortData.radioButton2.Checked))
                     && selectionResult == DialogResult.OK);

            if (selectionResult == DialogResult.OK)
            {
                MakeVisibleTable1();

                // Получаем выбранные значения ComboBox и RadioButton
                string sortBy = sortData.comboBox1.SelectedItem.ToString();
                string sortOrder = sortData.radioButton1.Checked ? "возрастания" : "убывания";

                // Сортируем DataGridView на форме
                dataGridView1.Sort(dataGridView1.Columns[sortBy],
                  sortOrder == "возрастания" ? ListSortDirection.Ascending : ListSortDirection.Descending);

                // Выводим сообщение пользователю об успешной сортировке данных
                MessageBox.Show($"Данные отсортированы по столбцу {sortBy} в порядке {sortOrder}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); ; ; ;
            }
            else
            {
                // Выводим сообщение пользователю об отмене сортировки записей
                MessageBox.Show("Сортировка записей отменена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        /// <summary>
        /// Создает таблицу-эксель с данными о задолженностях
        /// </summary>
        private void ExportToExcelDebts()
        {
            // Получаем путь к файлу, в который будем сохранять данные
            string filePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файлы Excel|*.xlsx";
            saveFileDialog.Title = "Сохранить отсортированную таблицу";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            // Создаем новый экземпляр класса ExcelPackage
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Добавляем лист в документ
                var worksheet = excelPackage.Workbook.Worksheets.Add("Таблица студентов");

                // Заполняем лист данными из таблицы dataGridView1
                DataTable dataTable = ((DataTable)dataGridView1.DataSource);

                for (int i = 1; i <= dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i].Value = dataTable.Columns[i - 1].ColumnName;
                }

                for (int i = 1; i <= dataTable.Rows.Count; i++)
                {
                    for (int j = 1; j <= dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 1, j].Value = dataTable.Rows[i - 1][j - 1].ToString();
                    }
                }

                // Сохраняем файл Excel
                FileInfo excelFile = new FileInfo(filePath);
                excelPackage.SaveAs(excelFile);
            }

            // Выводим сообщение пользователю об успешном сохранении данных в файл Excel
            MessageBox.Show($"Данные из таблицы сохранены в файл {filePath}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Создает таблицу-эксель с данными о средних баллых группы
        /// </summary>
        private void ExportToExcelAvg()
        {
            // Получаем путь к файлу, в который будем сохранять данные
            string filePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файлы Excel|*.xlsx";
            saveFileDialog.Title = "Сохранить отсортированную таблицу";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            // Создаем новый экземпляр класса ExcelPackage
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Добавляем лист в документ
                var worksheet = excelPackage.Workbook.Worksheets.Add("Таблица студентов");

                // Заполняем лист данными из таблицы dataGridView1
                DataTable dataTable = ((DataTable)dataGridView1.DataSource);

                for (int i = 1; i <= dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i].Value = dataTable.Columns[i - 1].ColumnName;
                }

                for (int i = 1; i <= dataTable.Rows.Count; i++)
                {
                    for (int j = 1; j <= dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 1, j].Value = dataTable.Rows[i - 1][j - 1].ToString();
                    }
                }

                // Добавляем заголовок для столбца "Средний балл ИТОГО"
                worksheet.Cells[1, dataTable.Columns.Count + 1].Value = "Средний балл ИТОГО";

                // Вычисляем средний балл по всей группе
                double groupAverage = (double)dataTable.Compute("AVG([Средний балл])", "");

                // Записываем значение среднего балла в ячейку в последней строке таблицы
                worksheet.Cells[dataTable.Rows.Count + 2, dataTable.Columns.Count + 1].Value = Math.Round(groupAverage, 3);

                // Сохраняем файл Excel
                FileInfo excelFile = new FileInfo(filePath);
                excelPackage.SaveAs(excelFile);
            }

            // Выводим сообщение пользователю об успешном сохранении данных в файл Excel
            MessageBox.Show($"Данные из таблицы сохранены в файл {filePath}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Сортировка таблицы по количеству задолженностей студентов по убыванию.
        /// </summary>
        private void SortByDebts()
        {
            // Получаем таблицу данных из DataGridView1
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DialogResult confirmResult = MessageBox.Show("Вы действительно хотите отсортировать таблицу по задолженностям?",
                "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.OK)
            {
                // добавляем новый столбец "Задолженность", если его еще нет в таблице
                if (!dataTable.Columns.Contains("Задолженность"))
                {
                    // Добавляем новую колонку со средними баллами
                    DataColumn debtsColumn = new DataColumn("Задолженность", typeof(int));
                    dataTable.Columns.Add(debtsColumn);
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    int debts = 0;
                    // проверяем задолженности и оценки для каждой из 5 дисциплин
                    for (int i = 1; i <= 5; i++)
                    {
                        // Если зачет не сдан, то добавляем задолженность
                        if (row["Зачет_" + i].ToString() == "False")
                            debts++;
                        // Если Отметка за экзамен меньше 4, то добавляем задолженность
                        if (int.Parse((row["Отметка_" + i]).ToString()) < 4)
                            debts++;
                    }
                    row["Задолженность"] = debts;
                }

                // Выводим сообщение пользователю об успешной сортировке записей
                MessageBox.Show($"Таблица отсортирована по количеству задолженностей студентов.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Сортируем таблицу по столбцу "Задолженности" в порядке убывания
                DataView sortedView = dataTable.DefaultView;
                sortedView.Sort = "Задолженность DESC";
                dataTable = sortedView.ToTable();

                // Обновляем таблицу на основной форме
                dataGridView1.DataSource = dataTable;

                RemoveAverageMarkColumn();

                DialogResult selectResult = MessageBox.Show("Вы хотите создать отчет по задолженностям?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (selectResult == DialogResult.Yes)
                {
                    // Сохраняем данные в файл Excel
                    ExportToExcelDebts();
                }
            }
            else
            {
                // Выводим сообщение пользователю об отмене сортировки записей
                MessageBox.Show("Сортировка записей по количеству задолженностей отменена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        /// <summary>
        /// Сортировка таблицы по среднему баллу студентов по убыванию.
        /// и вывод среднего балла во всей группе.
        /// </summary>
        private void SortByAverageMarks()
        {
            // Получаем таблицу данных из DataGridView2
            DataTable dataTable = (DataTable)dataGridView1.DataSource;

            ChooseGroup chooseGroup = new ChooseGroup();

            // Добавляем в comboBox элементы (если повторяются, то добавляем только один раз)
            foreach (var groupNumber in dataTable.AsEnumerable().Select(row => row.Field<string>("Номер_группы")).Distinct())
            {
                chooseGroup.comboBox1.Items.Add(groupNumber);
            }

            // Ожидаем пока пользователь выберет запись или закроет окно
            DialogResult selectionResult;
            do
            {
                selectionResult = chooseGroup.ShowDialog();
                if ((chooseGroup.comboBox1.SelectedIndex == -1) && selectionResult == DialogResult.OK)
                {
                    MessageBox.Show("Выберите группу.", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while ((chooseGroup.comboBox1.SelectedIndex == -1)
                     && selectionResult == DialogResult.OK);

            if (selectionResult == DialogResult.OK)
            {
                string selectedGroupNumber = chooseGroup.comboBox1.Text;
                // Фильтруем таблицу, оставляя только студентов нужной группы
                DataTable filteredTable = ((DataTable)dataGridView1.DataSource).
                Select("Номер_группы='" + selectedGroupNumber + "'").CopyToDataTable();

                // добавляем новый столбец "Задолженность", если его еще нет в таблице
                if (!filteredTable.Columns.Contains("Средний балл"))
                {
                    // Добавляем новую колонку со средними баллами
                    DataColumn averageColumn = new DataColumn("Средний балл", typeof(double));
                    filteredTable.Columns.Add(averageColumn);

                }

                double groupAverage = 0;
                int count = 0;
                foreach (DataRow row in filteredTable.Rows)
                {
                    double sum = 0;
                    for (int i = 1; i <= 5; i++)
                    {
                        string markString = row["Отметка_" + i].ToString();
                        sum += int.Parse(markString);
                        count++;
                    }
                    double average = sum / 5;
                    row["Средний балл"] = Math.Round(average, 3); ;
                    groupAverage += sum;
                }

                groupAverage /= count;
                // Выводим сообщение пользователю об успешном нахождении среднего балла всей группы
                MessageBox.Show($"Средний балл группы [{selectedGroupNumber}]: {groupAverage:f2}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Сортируем таблицу по столбцу "Средний балл" в порядке убывания
                DataView sortedView = filteredTable.DefaultView;
                sortedView.Sort = "Средний балл DESC";
                filteredTable = sortedView.ToTable();

                // Обновляем таблицу на основной форме
                dataGridView1.DataSource = filteredTable;

                RemoveDebtsColumn();
                DialogResult confirmResult = MessageBox.Show($"Вы хотите создать отчет по среднему баллу группы {selectedGroupNumber}?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Сохраняем данные в файл Excel
                    ExportToExcelAvg();
                }

            }
            else
            {
                // Выводим сообщение пользователю об отмене сортировки записей
                MessageBox.Show("Сортировка записей по среднему баллу отменена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        /// <summary>
        /// Метод сортирует выбранную пользователем группу по задолженностям
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сортировкаПоЗадолженностямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeVisibleTable1();
            SortByDebts();
        }

        /// <summary>
        /// Метод фильтрует таблицу по номеру группы, вычисляет средний балл каждого студента и сохраняет в словарь. 
        /// Затем вычисляется средний балл для всей группы, создается новая таблица и выводятся результаты в новом окне.
        /// </summary>
        private void сортировкаПоСрБаллуВГруппеВЦеломToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeVisibleTable1();
            SortByAverageMarks();
        }


        /// <summary>
        /// Отображает диалог "О программе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            info.ShowDialog();
        }

        /// <summary>
        /// Закрытие окна администратора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выходStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}