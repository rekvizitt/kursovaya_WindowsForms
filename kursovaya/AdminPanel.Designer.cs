namespace kursovaya
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьФайлToolStripMenuItem = new ToolStripMenuItem();
            открытьФайлToolStripMenuItem = new ToolStripMenuItem();
            удалитьФайлToolStripMenuItem = new ToolStripMenuItem();
            работаСДаннымиToolStripMenuItem = new ToolStripMenuItem();
            режимРедактированияToolStripMenuItem1 = new ToolStripMenuItem();
            просмотрВсехДанныхToolStripMenuItem = new ToolStripMenuItem();
            добавитьНовуюЗаписьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьЗаписьToolStripMenuItem = new ToolStripMenuItem();
            удалитьЗаписьToolStripMenuItem = new ToolStripMenuItem();
            обработкаДанныхToolStripMenuItem = new ToolStripMenuItem();
            поискДанныхToolStripMenuItem = new ToolStripMenuItem();
            сортировкаДанныхToolStripMenuItem = new ToolStripMenuItem();
            индивидЗаданиеToolStripMenuItem = new ToolStripMenuItem();
            сортировкаПоЗадолженностямToolStripMenuItem = new ToolStripMenuItem();
            сортировкаПоСрБаллуВГруппеВЦеломToolStripMenuItem = new ToolStripMenuItem();
            управлениеУчЗаписямиToolStripMenuItem = new ToolStripMenuItem();
            просмотрВсехУчЗаписейToolStripMenuItem = new ToolStripMenuItem();
            добавитьНовуюУчЗаписьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьУчЗаписиToolStripMenuItem = new ToolStripMenuItem();
            удалениеУчЗаписиToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            выходStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(10, 77, 104);
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(0, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(782, 522);
            dataGridView1.TabIndex = 0;
            dataGridView1.Visible = false;
            dataGridView1.ColumnAdded += dataGridView1_ColumnAdded;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, работаСДаннымиToolStripMenuItem, управлениеУчЗаписямиToolStripMenuItem, помощьToolStripMenuItem, выходStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьФайлToolStripMenuItem, открытьФайлToolStripMenuItem, удалитьФайлToolStripMenuItem });
            файлToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(64, 27);
            файлToolStripMenuItem.Text = "Файл";
            файлToolStripMenuItem.TextAlign = ContentAlignment.TopLeft;
            // 
            // создатьФайлToolStripMenuItem
            // 
            создатьФайлToolStripMenuItem.Name = "создатьФайлToolStripMenuItem";
            создатьФайлToolStripMenuItem.Size = new Size(205, 28);
            создатьФайлToolStripMenuItem.Text = "Создать файл";
            создатьФайлToolStripMenuItem.ToolTipText = "Создать новый файл для отображения информации о студентах";
            создатьФайлToolStripMenuItem.Click += создатьФайлToolStripMenuItem_Click;
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(205, 28);
            открытьФайлToolStripMenuItem.Text = "Открыть файл";
            открытьФайлToolStripMenuItem.ToolTipText = "Открыть файл для отображения информации о студентах";
            открытьФайлToolStripMenuItem.Click += открытьФайлToolStripMenuItem_Click;
            // 
            // удалитьФайлToolStripMenuItem
            // 
            удалитьФайлToolStripMenuItem.Name = "удалитьФайлToolStripMenuItem";
            удалитьФайлToolStripMenuItem.Size = new Size(205, 28);
            удалитьФайлToolStripMenuItem.Text = "Удалить файл";
            удалитьФайлToolStripMenuItem.ToolTipText = "Удалить файл с информацией о студентах";
            удалитьФайлToolStripMenuItem.Click += удалитьФайлToolStripMenuItem_Click;
            // 
            // работаСДаннымиToolStripMenuItem
            // 
            работаСДаннымиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { режимРедактированияToolStripMenuItem1, обработкаДанныхToolStripMenuItem });
            работаСДаннымиToolStripMenuItem.Enabled = false;
            работаСДаннымиToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            работаСДаннымиToolStripMenuItem.Name = "работаСДаннымиToolStripMenuItem";
            работаСДаннымиToolStripMenuItem.Size = new Size(169, 27);
            работаСДаннымиToolStripMenuItem.Text = "Работа с данными";
            работаСДаннымиToolStripMenuItem.TextAlign = ContentAlignment.TopLeft;
            // 
            // режимРедактированияToolStripMenuItem1
            // 
            режимРедактированияToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { просмотрВсехДанныхToolStripMenuItem, добавитьНовуюЗаписьToolStripMenuItem, редактироватьЗаписьToolStripMenuItem, удалитьЗаписьToolStripMenuItem });
            режимРедактированияToolStripMenuItem1.Name = "режимРедактированияToolStripMenuItem1";
            режимРедактированияToolStripMenuItem1.Size = new Size(282, 28);
            режимРедактированияToolStripMenuItem1.Text = "Режим редактирования";
            // 
            // просмотрВсехДанныхToolStripMenuItem
            // 
            просмотрВсехДанныхToolStripMenuItem.Name = "просмотрВсехДанныхToolStripMenuItem";
            просмотрВсехДанныхToolStripMenuItem.Size = new Size(285, 28);
            просмотрВсехДанныхToolStripMenuItem.Text = "Просмотр всех данных";
            просмотрВсехДанныхToolStripMenuItem.ToolTipText = "Просмотреть все данные о студентах в виде таблицы";
            просмотрВсехДанныхToolStripMenuItem.Click += просмотрВсехДанныхToolStripMenuItem_Click;
            // 
            // добавитьНовуюЗаписьToolStripMenuItem
            // 
            добавитьНовуюЗаписьToolStripMenuItem.Name = "добавитьНовуюЗаписьToolStripMenuItem";
            добавитьНовуюЗаписьToolStripMenuItem.Size = new Size(285, 28);
            добавитьНовуюЗаписьToolStripMenuItem.Text = "Добавить новую запись";
            добавитьНовуюЗаписьToolStripMenuItem.ToolTipText = "Добавить новую запись в файл с информацией о студентах";
            добавитьНовуюЗаписьToolStripMenuItem.Click += добавитьНовуюЗаписьToolStripMenuItem_Click;
            // 
            // редактироватьЗаписьToolStripMenuItem
            // 
            редактироватьЗаписьToolStripMenuItem.Name = "редактироватьЗаписьToolStripMenuItem";
            редактироватьЗаписьToolStripMenuItem.Size = new Size(285, 28);
            редактироватьЗаписьToolStripMenuItem.Text = "Редактировать запись";
            редактироватьЗаписьToolStripMenuItem.ToolTipText = "Редактировать запись в файле с информацией о студентах";
            редактироватьЗаписьToolStripMenuItem.Click += редактироватьЗаписьToolStripMenuItem_Click;
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            удалитьЗаписьToolStripMenuItem.Size = new Size(285, 28);
            удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            удалитьЗаписьToolStripMenuItem.ToolTipText = "Удалить запись в файле с информацией о студентах";
            удалитьЗаписьToolStripMenuItem.Click += удалитьЗаписьToolStripMenuItem_Click;
            // 
            // обработкаДанныхToolStripMenuItem
            // 
            обработкаДанныхToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поискДанныхToolStripMenuItem, сортировкаДанныхToolStripMenuItem, индивидЗаданиеToolStripMenuItem });
            обработкаДанныхToolStripMenuItem.Name = "обработкаДанныхToolStripMenuItem";
            обработкаДанныхToolStripMenuItem.Size = new Size(282, 28);
            обработкаДанныхToolStripMenuItem.Text = "Обработка данных";
            // 
            // поискДанныхToolStripMenuItem
            // 
            поискДанныхToolStripMenuItem.Name = "поискДанныхToolStripMenuItem";
            поискДанныхToolStripMenuItem.Size = new Size(251, 28);
            поискДанныхToolStripMenuItem.Text = "Поиск данных";
            поискДанныхToolStripMenuItem.ToolTipText = "Поиск данных в таблице по параметру и значнию\r\n";
            поискДанныхToolStripMenuItem.Click += поискДанныхToolStripMenuItem_Click;
            // 
            // сортировкаДанныхToolStripMenuItem
            // 
            сортировкаДанныхToolStripMenuItem.Name = "сортировкаДанныхToolStripMenuItem";
            сортировкаДанныхToolStripMenuItem.Size = new Size(251, 28);
            сортировкаДанныхToolStripMenuItem.Text = "Сортировка данных";
            сортировкаДанныхToolStripMenuItem.ToolTipText = "Сортировка данных таблицы по параметру и виду сортировки\r\n";
            сортировкаДанныхToolStripMenuItem.Click += сортировкаДанныхToolStripMenuItem_Click_1;
            // 
            // индивидЗаданиеToolStripMenuItem
            // 
            индивидЗаданиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сортировкаПоЗадолженностямToolStripMenuItem, сортировкаПоСрБаллуВГруппеВЦеломToolStripMenuItem });
            индивидЗаданиеToolStripMenuItem.Name = "индивидЗаданиеToolStripMenuItem";
            индивидЗаданиеToolStripMenuItem.Size = new Size(251, 28);
            индивидЗаданиеToolStripMenuItem.Text = "Индивид. задание";
            // 
            // сортировкаПоЗадолженностямToolStripMenuItem
            // 
            сортировкаПоЗадолженностямToolStripMenuItem.Name = "сортировкаПоЗадолженностямToolStripMenuItem";
            сортировкаПоЗадолженностямToolStripMenuItem.Size = new Size(485, 28);
            сортировкаПоЗадолженностямToolStripMenuItem.Text = "Сортировка по задолженностям(по убыванию)";
            сортировкаПоЗадолженностямToolStripMenuItem.ToolTipText = "Сортировка таблицы по убыванию по задолженностям";
            сортировкаПоЗадолженностямToolStripMenuItem.Click += сортировкаПоЗадолженностямToolStripMenuItem_Click;
            // 
            // сортировкаПоСрБаллуВГруппеВЦеломToolStripMenuItem
            // 
            сортировкаПоСрБаллуВГруппеВЦеломToolStripMenuItem.Name = "сортировкаПоСрБаллуВГруппеВЦеломToolStripMenuItem";
            сортировкаПоСрБаллуВГруппеВЦеломToolStripMenuItem.Size = new Size(485, 28);
            сортировкаПоСрБаллуВГруппеВЦеломToolStripMenuItem.Text = "Сортировка по ср. баллу в группе (по убыванию)";
            сортировкаПоСрБаллуВГруппеВЦеломToolStripMenuItem.ToolTipText = "Сортировка данных таблицы по убыванию по среднему баллу в группе у каждого студента\r\nВывод значения среднего балла в группе\r\n";
            сортировкаПоСрБаллуВГруппеВЦеломToolStripMenuItem.Click += сортировкаПоСрБаллуВГруппеВЦеломToolStripMenuItem_Click;
            // 
            // управлениеУчЗаписямиToolStripMenuItem
            // 
            управлениеУчЗаписямиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { просмотрВсехУчЗаписейToolStripMenuItem, добавитьНовуюУчЗаписьToolStripMenuItem, редактироватьУчЗаписиToolStripMenuItem, удалениеУчЗаписиToolStripMenuItem });
            управлениеУчЗаписямиToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            управлениеУчЗаписямиToolStripMenuItem.Name = "управлениеУчЗаписямиToolStripMenuItem";
            управлениеУчЗаписямиToolStripMenuItem.Size = new Size(227, 27);
            управлениеУчЗаписямиToolStripMenuItem.Text = "Управление уч. записями";
            управлениеУчЗаписямиToolStripMenuItem.TextAlign = ContentAlignment.TopLeft;
            // 
            // просмотрВсехУчЗаписейToolStripMenuItem
            // 
            просмотрВсехУчЗаписейToolStripMenuItem.Name = "просмотрВсехУчЗаписейToolStripMenuItem";
            просмотрВсехУчЗаписейToolStripMenuItem.Size = new Size(325, 28);
            просмотрВсехУчЗаписейToolStripMenuItem.Text = "Просмотреть все уч. записей";
            просмотрВсехУчЗаписейToolStripMenuItem.ToolTipText = "Просмотреть все учетные записи в виде таблицы";
            просмотрВсехУчЗаписейToolStripMenuItem.Click += просмотрВсехУчЗаписейToolStripMenuItem_Click;
            // 
            // добавитьНовуюУчЗаписьToolStripMenuItem
            // 
            добавитьНовуюУчЗаписьToolStripMenuItem.Name = "добавитьНовуюУчЗаписьToolStripMenuItem";
            добавитьНовуюУчЗаписьToolStripMenuItem.Size = new Size(325, 28);
            добавитьНовуюУчЗаписьToolStripMenuItem.Text = "Добавить новую уч. запись";
            добавитьНовуюУчЗаписьToolStripMenuItem.ToolTipText = "Добавить новую учетную запись в файл с учетными записями";
            добавитьНовуюУчЗаписьToolStripMenuItem.Click += добавитьНовуюУчЗаписьToolStripMenuItem_Click;
            // 
            // редактироватьУчЗаписиToolStripMenuItem
            // 
            редактироватьУчЗаписиToolStripMenuItem.Name = "редактироватьУчЗаписиToolStripMenuItem";
            редактироватьУчЗаписиToolStripMenuItem.Size = new Size(325, 28);
            редактироватьУчЗаписиToolStripMenuItem.Text = "Редактировать уч. запись";
            редактироватьУчЗаписиToolStripMenuItem.ToolTipText = "Редактировать учетную запись в файле с учетными записями\r\n";
            редактироватьУчЗаписиToolStripMenuItem.Click += редактироватьУчЗаписиToolStripMenuItem_Click;
            // 
            // удалениеУчЗаписиToolStripMenuItem
            // 
            удалениеУчЗаписиToolStripMenuItem.Name = "удалениеУчЗаписиToolStripMenuItem";
            удалениеУчЗаписиToolStripMenuItem.Size = new Size(325, 28);
            удалениеУчЗаписиToolStripMenuItem.Text = "Удаление уч. запись";
            удалениеУчЗаписиToolStripMenuItem.ToolTipText = "Удалить учетную запись в файле с учетными записями\r\n";
            удалениеУчЗаписиToolStripMenuItem.Click += удалениеУчЗаписиToolStripMenuItem_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            помощьToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(91, 27);
            помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(201, 28);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.ToolTipText = "Отобразить информацию о программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // выходStripMenuItem
            // 
            выходStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            выходStripMenuItem.Name = "выходStripMenuItem";
            выходStripMenuItem.Size = new Size(73, 27);
            выходStripMenuItem.Text = "Выход";
            выходStripMenuItem.Click += выходStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.BackgroundColor = Color.FromArgb(10, 77, 104);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.Location = new Point(0, 31);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(782, 522);
            dataGridView2.TabIndex = 2;
            dataGridView2.Visible = false;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 77, 104);
            ClientSize = new Size(782, 553);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сведения об успеваемости студентов (Администратор)";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьФайлToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem удалитьФайлToolStripMenuItem;
        private ToolStripMenuItem работаСДаннымиToolStripMenuItem;
        private ToolStripMenuItem управлениеУчЗаписямиToolStripMenuItem;
        private ToolStripMenuItem просмотрВсехУчЗаписейToolStripMenuItem;
        private ToolStripMenuItem добавитьНовуюУчЗаписьToolStripMenuItem;
        private ToolStripMenuItem редактироватьУчЗаписиToolStripMenuItem;
        private ToolStripMenuItem удалениеУчЗаписиToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem режимРедактированияToolStripMenuItem1;
        private ToolStripMenuItem просмотрВсехДанныхToolStripMenuItem;
        private ToolStripMenuItem добавитьНовуюЗаписьToolStripMenuItem;
        private ToolStripMenuItem редактироватьЗаписьToolStripMenuItem;
        private ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private ToolStripMenuItem обработкаДанныхToolStripMenuItem;
        private ToolStripMenuItem поискДанныхToolStripMenuItem;
        private ToolStripMenuItem сортировкаДанныхToolStripMenuItem;
        private ToolStripMenuItem индивидЗаданиеToolStripMenuItem;
        private ToolStripMenuItem сортировкаПоЗадолженностямToolStripMenuItem;
        private ToolStripMenuItem сортировкаПоСрБаллуВГруппеВЦеломToolStripMenuItem;
        private DataGridView dataGridView2;
        public DataGridView dataGridView1;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem выходStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}