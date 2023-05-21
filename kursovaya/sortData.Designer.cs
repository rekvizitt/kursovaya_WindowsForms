namespace kursovaya
{
    partial class SortData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortData));
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 255, 202);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(454, 64);
            label1.TabIndex = 0;
            label1.Text = "Выберите параметр для сортировки";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Номер_группы", "Ф.И.О.", "Зачет_1", "Зачет_2", "Зачет_3", "Зачет_4", "Зачет_5", "Отметка_1", "Отметка_2", "Отметка_3", "Отметка_4", "Отметка_5 " });
            comboBox1.Location = new Point(11, 73);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(430, 28);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 255, 202);
            button1.Location = new Point(2, 280);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(223, 71);
            button1.TabIndex = 5;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 255, 202);
            button2.Location = new Point(231, 280);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(221, 71);
            button2.TabIndex = 6;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 255, 202);
            groupBox1.Location = new Point(98, 118);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вариант сортировки";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.FromArgb(0, 255, 202);
            radioButton1.Location = new Point(6, 26);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(196, 32);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "По возрастанию";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.FromArgb(0, 255, 202);
            radioButton2.Location = new Point(6, 66);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(171, 32);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "По убыванию";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // SortData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 77, 104);
            ClientSize = new Size(454, 353);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SortData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Сортировка данных";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        public ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        public RadioButton radioButton1;
        public RadioButton radioButton2;
    }
}