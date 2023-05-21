namespace kursovaya
{
    partial class FindData
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindData));
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 255, 202);
            label1.Location = new Point(17, 7);
            label1.Name = "label1";
            label1.Size = new Size(353, 90);
            label1.TabIndex = 0;
            label1.Text = "Выберите параметр поиска";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Номер_группы", "Ф.И.О.", "Зачет_1", "Зачет_2", "Зачет_3", "Зачет_4", "Зачет_5", "Отметка_1", "Отметка_2", "Отметка_3", "Отметка_4", "Отметка_5 " });
            comboBox1.Location = new Point(12, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(358, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 255, 202);
            label2.Location = new Point(2, 130);
            label2.Name = "label2";
            label2.Size = new Size(382, 90);
            label2.TabIndex = 2;
            label2.Text = "Введите значение параметра";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(10, 77, 104);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 255, 202);
            button1.Location = new Point(0, 398);
            button1.Name = "button1";
            button1.Size = new Size(188, 70);
            button1.TabIndex = 4;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(10, 77, 104);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 255, 202);
            button2.Location = new Point(213, 398);
            button2.Name = "button2";
            button2.Size = new Size(190, 70);
            button2.TabIndex = 5;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 27);
            textBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 255, 202);
            groupBox1.Location = new Point(45, 247);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 120);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск параметра по значению";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(3, 83);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(80, 27);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Равно";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(3, 53);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(100, 27);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Меньше";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(3, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 27);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Больше";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // FindData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 77, 104);
            ClientSize = new Size(406, 471);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FindData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Поиск данных";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        public ComboBox comboBox1;
        public TextBox textBox1;
        public GroupBox groupBox1;
        public RadioButton radioButton3;
        public RadioButton radioButton2;
        public RadioButton radioButton1;
        private ErrorProvider errorProvider1;
    }
}