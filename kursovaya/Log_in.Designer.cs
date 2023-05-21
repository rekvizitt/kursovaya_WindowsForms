namespace kursovaya
{
    partial class Log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 255, 202);
            label1.Location = new Point(29, 83);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 255, 202);
            label2.Location = new Point(16, 140);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 131, 149);
            button1.Dock = DockStyle.Bottom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 255, 202);
            button1.Location = new Point(0, 242);
            button1.Name = "button1";
            button1.Size = new Size(382, 111);
            button1.TabIndex = 4;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 255, 202);
            label3.Location = new Point(69, 202);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 255, 202);
            label4.Location = new Point(52, 9);
            label4.Name = "label4";
            label4.Size = new Size(280, 54);
            label4.TabIndex = 6;
            label4.Text = "Авторизация";
            // 
            // checkBox1
            // 
            checkBox1.Image = (Image)resources.GetObject("checkBox1.Image");
            checkBox1.Location = new Point(308, 142);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 32);
            checkBox1.TabIndex = 7;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Log_in
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 77, 104);
            ClientSize = new Size(382, 353);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Log_in";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private ErrorProvider errorProvider1;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
    }
}