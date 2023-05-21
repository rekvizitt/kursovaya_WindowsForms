namespace kursovaya
{
    partial class addUserData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUserData));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 255, 202);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(358, 101);
            label1.TabIndex = 0;
            label1.Text = "Добавить учетную запись";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 27);
            textBox2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 255, 202);
            groupBox1.Location = new Point(73, 210);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 85);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Роль";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.FromArgb(0, 255, 202);
            radioButton2.Location = new Point(11, 51);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(165, 27);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Администратор";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.FromArgb(0, 255, 202);
            radioButton1.Location = new Point(11, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(148, 27);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Пользователь";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 255, 202);
            label2.Location = new Point(15, 101);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 4;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 255, 202);
            label3.Location = new Point(11, 160);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 5;
            label3.Text = "Пароль";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 255, 202);
            button1.Location = new Point(0, 334);
            button1.Name = "button1";
            button1.Size = new Size(162, 80);
            button1.TabIndex = 6;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 255, 202);
            button2.Location = new Point(199, 334);
            button2.Name = "button2";
            button2.Size = new Size(159, 80);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // addUserData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 77, 104);
            ClientSize = new Size(358, 416);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(0, 255, 202);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "addUserData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление учетной записи";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        public TextBox textBox1;
        public TextBox textBox2;
        public RadioButton radioButton2;
        public RadioButton radioButton1;
        public Label label1;
        public GroupBox groupBox1;
        private ErrorProvider errorProvider1;
    }
}