namespace kursovaya
{
    partial class DeleteData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteData));
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(360, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 255, 202);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(382, 124);
            label1.TabIndex = 1;
            label1.Text = "Выберите строку, которую хотите удалить";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 255, 202);
            button1.Location = new Point(1, 271);
            button1.Name = "button1";
            button1.Size = new Size(182, 80);
            button1.TabIndex = 2;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 255, 202);
            button2.Location = new Point(199, 271);
            button2.Name = "button2";
            button2.Size = new Size(182, 80);
            button2.TabIndex = 3;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // DeleteData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 77, 104);
            ClientSize = new Size(382, 353);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Удаление записи";
            ResumeLayout(false);
        }

        #endregion

        public ComboBox comboBox1;
        private Button button1;
        private Button button2;
        public Label label1;
    }
}