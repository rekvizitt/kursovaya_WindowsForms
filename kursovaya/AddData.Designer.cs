namespace kursovaya
{
    partial class AddData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddData));
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(130, 21);
            maskedTextBox1.Mask = "000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PromptChar = '-';
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 255, 202);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 125);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Зачёты";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox5.ForeColor = Color.FromArgb(0, 255, 202);
            checkBox5.Location = new Point(100, 56);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(84, 24);
            checkBox5.TabIndex = 22;
            checkBox5.Text = "Зачёт 5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.ForeColor = Color.FromArgb(0, 255, 202);
            checkBox4.Location = new Point(100, 26);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(84, 24);
            checkBox4.TabIndex = 21;
            checkBox4.Text = "Зачёт 4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(0, 255, 202);
            checkBox1.Location = new Point(13, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 24);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Зачёт 1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.ForeColor = Color.FromArgb(0, 255, 202);
            checkBox3.Location = new Point(13, 83);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(84, 24);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "Зачёт 3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.FromArgb(0, 255, 202);
            checkBox2.Location = new Point(13, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(84, 24);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Зачёт 2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(0, 255, 202);
            groupBox2.Location = new Point(13, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 222);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Экзамены";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(99, 173);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 255, 202);
            label5.Location = new Point(13, 176);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 15;
            label5.Text = "Отметка 5";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(99, 140);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(99, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 255, 202);
            label4.Location = new Point(13, 146);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 14;
            label4.Text = "Отметка 4";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(99, 74);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 255, 202);
            label3.Location = new Point(13, 113);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 13;
            label3.Text = "Отметка 3";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(99, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 255, 202);
            label2.Location = new Point(13, 80);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 12;
            label2.Text = "Отметка 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 255, 202);
            label1.Location = new Point(13, 45);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 11;
            label1.Text = "Отметка 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 255, 202);
            label6.Location = new Point(12, 21);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 16;
            label6.Text = "Номер группы";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 255, 202);
            label7.Location = new Point(76, 57);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 17;
            label7.Text = "Ф.И.О.";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 255, 202);
            button1.Location = new Point(4, 462);
            button1.Name = "button1";
            button1.Size = new Size(155, 48);
            button1.TabIndex = 18;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 255, 202);
            button2.Location = new Point(172, 462);
            button2.Name = "button2";
            button2.Size = new Size(148, 48);
            button2.TabIndex = 19;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // AddData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 77, 104);
            ClientSize = new Size(324, 513);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить запись";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Button button2;
        public TextBox textBox1;
        public MaskedTextBox maskedTextBox1;
        public ErrorProvider errorProvider1;
        public GroupBox groupBox2;
        public GroupBox groupBox1;
        public CheckBox checkBox5;
        public CheckBox checkBox4;
        public CheckBox checkBox1;
        public CheckBox checkBox3;
        public CheckBox checkBox2;
        public TextBox textBox6;
        public TextBox textBox5;
        public TextBox textBox4;
        public TextBox textBox3;
        public TextBox textBox2;
        public Button button1;
    }
}