namespace kursovaya
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            вернутьсяНаГлавноеОкноToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(10, 77, 104);
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 255, 202);
            textBox1.Location = new Point(0, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(732, 472);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { вернутьсяНаГлавноеОкноToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(732, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // вернутьсяНаГлавноеОкноToolStripMenuItem
            // 
            вернутьсяНаГлавноеОкноToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            вернутьсяНаГлавноеОкноToolStripMenuItem.Name = "вернутьсяНаГлавноеОкноToolStripMenuItem";
            вернутьсяНаГлавноеОкноToolStripMenuItem.Size = new Size(239, 27);
            вернутьсяНаГлавноеОкноToolStripMenuItem.Text = "Вернуться на главное окно";
            вернутьсяНаГлавноеОкноToolStripMenuItem.ToolTipText = "Закрыть окно \"О программе\"";
            вернутьсяНаГлавноеОкноToolStripMenuItem.Click += вернутьсяНаГлавноеОкноToolStripMenuItem_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 77, 104);
            ClientSize = new Size(732, 503);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InfoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            Load += InfoForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem вернутьсяНаГлавноеОкноToolStripMenuItem;
    }
}