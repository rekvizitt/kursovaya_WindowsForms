namespace kursovaya
{
    partial class ChooseGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseGroup));
            label1 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 255, 202);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(382, 134);
            label1.TabIndex = 0;
            label1.Text = "Выберите группу для нахождения среднего балла";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(358, 28);
            comboBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 255, 202);
            button2.Location = new Point(191, 282);
            button2.Name = "button2";
            button2.Size = new Size(190, 70);
            button2.TabIndex = 8;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 255, 202);
            button1.Location = new Point(1, 282);
            button1.Name = "button1";
            button1.Size = new Size(188, 70);
            button1.TabIndex = 7;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            // 
            // ChooseGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 77, 104);
            ClientSize = new Size(382, 353);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChooseGroup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Выберите группу";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        public ComboBox comboBox1;
        private Button button2;
        private Button button1;
    }
}