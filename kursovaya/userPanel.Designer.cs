namespace kursovaya
{
    partial class userPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userPanel));
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьФайлToolStripMenuItem = new ToolStripMenuItem();
            работаСДаннымиToolStripMenuItem = new ToolStripMenuItem();
            режимРедактированияToolStripMenuItem = new ToolStripMenuItem();
            просмотрВсехДанныхToolStripMenuItem = new ToolStripMenuItem();
            обработкаДанныхToolStripMenuItem = new ToolStripMenuItem();
            поискДанныхToolStripMenuItem = new ToolStripMenuItem();
            сортировкаДанныхToolStripMenuItem = new ToolStripMenuItem();
            индивидЗаданиеToolStripMenuItem = new ToolStripMenuItem();
            сортировкаПоЗадолженностямПоУбываниюToolStripMenuItem = new ToolStripMenuItem();
            сортировкаПоСрБаллуВГруппепоУбываниюToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(10, 77, 104);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(0, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(782, 522);
            dataGridView1.TabIndex = 1;
            dataGridView1.Visible = false;
            dataGridView1.ColumnAdded += dataGridView1_ColumnAdded;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, работаСДаннымиToolStripMenuItem, помощьToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 31);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem });
            файлToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(64, 27);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(205, 28);
            открытьФайлToolStripMenuItem.Text = "Открыть файл";
            открытьФайлToolStripMenuItem.ToolTipText = "Открыть файл для отображения информации о студентах";
            открытьФайлToolStripMenuItem.Click += открытьФайлToolStripMenuItem_Click;
            // 
            // работаСДаннымиToolStripMenuItem
            // 
            работаСДаннымиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { режимРедактированияToolStripMenuItem, обработкаДанныхToolStripMenuItem });
            работаСДаннымиToolStripMenuItem.Enabled = false;
            работаСДаннымиToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            работаСДаннымиToolStripMenuItem.Name = "работаСДаннымиToolStripMenuItem";
            работаСДаннымиToolStripMenuItem.Size = new Size(169, 27);
            работаСДаннымиToolStripMenuItem.Text = "Работа с данными";
            // 
            // режимРедактированияToolStripMenuItem
            // 
            режимРедактированияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { просмотрВсехДанныхToolStripMenuItem });
            режимРедактированияToolStripMenuItem.Name = "режимРедактированияToolStripMenuItem";
            режимРедактированияToolStripMenuItem.Size = new Size(282, 28);
            режимРедактированияToolStripMenuItem.Text = "Режим редактирования";
            // 
            // просмотрВсехДанныхToolStripMenuItem
            // 
            просмотрВсехДанныхToolStripMenuItem.Name = "просмотрВсехДанныхToolStripMenuItem";
            просмотрВсехДанныхToolStripMenuItem.Size = new Size(275, 28);
            просмотрВсехДанныхToolStripMenuItem.Text = "Просмотр всех данных";
            просмотрВсехДанныхToolStripMenuItem.ToolTipText = "Просмотреть все данные о студентах в виде таблицы";
            просмотрВсехДанныхToolStripMenuItem.Click += просмотрВсехДанныхToolStripMenuItem_Click;
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
            поискДанныхToolStripMenuItem.ToolTipText = "Поиск данных в таблице по параметру и значнию";
            поискДанныхToolStripMenuItem.Click += поискДанныхToolStripMenuItem_Click;
            // 
            // сортировкаДанныхToolStripMenuItem
            // 
            сортировкаДанныхToolStripMenuItem.Name = "сортировкаДанныхToolStripMenuItem";
            сортировкаДанныхToolStripMenuItem.Size = new Size(251, 28);
            сортировкаДанныхToolStripMenuItem.Text = "Сортировка данных";
            сортировкаДанныхToolStripMenuItem.ToolTipText = "Сортировка данных таблицы по параметру и виду сортировки";
            сортировкаДанныхToolStripMenuItem.Click += сортировкаДанныхToolStripMenuItem_Click;
            // 
            // индивидЗаданиеToolStripMenuItem
            // 
            индивидЗаданиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сортировкаПоЗадолженностямПоУбываниюToolStripMenuItem, сортировкаПоСрБаллуВГруппепоУбываниюToolStripMenuItem });
            индивидЗаданиеToolStripMenuItem.Name = "индивидЗаданиеToolStripMenuItem";
            индивидЗаданиеToolStripMenuItem.Size = new Size(251, 28);
            индивидЗаданиеToolStripMenuItem.Text = "Индивид. задание";
            // 
            // сортировкаПоЗадолженностямПоУбываниюToolStripMenuItem
            // 
            сортировкаПоЗадолженностямПоУбываниюToolStripMenuItem.Name = "сортировкаПоЗадолженностямПоУбываниюToolStripMenuItem";
            сортировкаПоЗадолженностямПоУбываниюToolStripMenuItem.Size = new Size(485, 28);
            сортировкаПоЗадолженностямПоУбываниюToolStripMenuItem.Text = "Сортировка по задолженностям( по убыванию)";
            сортировкаПоЗадолженностямПоУбываниюToolStripMenuItem.ToolTipText = "Сортировка таблицы по убыванию по задолженностям";
            сортировкаПоЗадолженностямПоУбываниюToolStripMenuItem.Click += сортировкаПоЗадолженностямПоУбываниюToolStripMenuItem_Click;
            // 
            // сортировкаПоСрБаллуВГруппепоУбываниюToolStripMenuItem
            // 
            сортировкаПоСрБаллуВГруппепоУбываниюToolStripMenuItem.Name = "сортировкаПоСрБаллуВГруппепоУбываниюToolStripMenuItem";
            сортировкаПоСрБаллуВГруппепоУбываниюToolStripMenuItem.Size = new Size(485, 28);
            сортировкаПоСрБаллуВГруппепоУбываниюToolStripMenuItem.Text = "Сортировка по ср. баллу в группе (по убыванию)";
            сортировкаПоСрБаллуВГруппепоУбываниюToolStripMenuItem.ToolTipText = "Сортировка данных таблицы по убыванию по среднему баллу в группе у каждого студента";
            сортировкаПоСрБаллуВГруппепоУбываниюToolStripMenuItem.Click += сортировкаПоСрБаллуВГруппепоУбываниюToolStripMenuItem_Click;
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
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(73, 27);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // userPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 77, 104);
            ClientSize = new Size(782, 553);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "userPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сведения об успеваемости студентов (Пользователь)";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem работаСДаннымиToolStripMenuItem;
        private ToolStripMenuItem режимРедактированияToolStripMenuItem;
        private ToolStripMenuItem обработкаДанныхToolStripMenuItem;
        private ToolStripMenuItem просмотрВсехДанныхToolStripMenuItem;
        private ToolStripMenuItem поискДанныхToolStripMenuItem;
        private ToolStripMenuItem сортировкаДанныхToolStripMenuItem;
        private ToolStripMenuItem индивидЗаданиеToolStripMenuItem;
        private ToolStripMenuItem сортировкаПоЗадолженностямПоУбываниюToolStripMenuItem;
        private ToolStripMenuItem сортировкаПоСрБаллуВГруппепоУбываниюToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}