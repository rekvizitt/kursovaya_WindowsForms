using System.ComponentModel;
using System.Data;
using OfficeOpenXml;

namespace kursovaya
{
    public partial class userPanel : Form
    {
        public string fileName;

        public userPanel()
        {
            InitializeComponent();
            CreateDataTable();
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
        /// Обновляем данные таблицы (добавляем новые строки в dataGridView1).
        /// </summary>
        private void RefreshTable()
        {
            RemoveDebtsColumn();
            RemoveAverageMarkColumn();
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
        /// Удаляет из таблицы колонку "Средний балл", если она существует
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
                dataGridView1.Visible = true;

                // Очищаем строки таблицы после открытия файла.
                ClearRows();

                fileName = openFileDialog.FileName;
                using (StreamReader file = new StreamReader(fileName))
                {
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
        /// Просмотр всех данных о студентах из файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void просмотрВсехДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обновляем таблицу dataGridView1
            RefreshTable();

            // Выводим сообщение пользователю о том, что таблица успешно обновлена
            MessageBox.Show("Таблица успешно обновлена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void сортировкаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
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
        // 
        /// <summary>
        /// Метод фильтрует таблицу по номеру группы, вычисляет средний балл каждого студента и сохраняет в словарь. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сортировкаПоЗадолженностямПоУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortByDebts();
        }

        /// <summary>
        /// фильтрует таблицу по заданному номеру группы, для каждого студента в группе 
        /// вычисляет средний балл по экзаменам, средний балл для всей группы и создает новую таблицу для отображения результатов.
        /// </summary>
        private void сортировкаПоСрБаллуВГруппепоУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        /// Закрытие окна пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}