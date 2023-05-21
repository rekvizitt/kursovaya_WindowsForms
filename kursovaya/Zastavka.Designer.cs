namespace kursovaya
{
    partial class Zastavka
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zastavka));
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Candara Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(5, 191, 219);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(782, 353);
            label1.TabIndex = 0;
            label1.Text = "Курсовая работа\r\nУчет успеваемости студентов\r\nВыполнил: Чекавый В.В.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 131, 149);
            button1.Dock = DockStyle.Bottom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(5, 191, 219);
            button1.Location = new Point(0, 356);
            button1.Name = "button1";
            button1.Size = new Size(782, 237);
            button1.TabIndex = 1;
            button1.Text = "Авторизация";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Zastavka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 77, 104);
            ClientSize = new Size(782, 593);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Zastavka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заставка";
            TransparencyKey = Color.FromArgb(201, 219, 178);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}