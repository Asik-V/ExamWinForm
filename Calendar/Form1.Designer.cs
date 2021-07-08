namespace Calendar
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.укрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGPanelWithInstrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(79, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.engToolStripMenuItem,
            this.русToolStripMenuItem,
            this.укрToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // engToolStripMenuItem
            // 
            this.engToolStripMenuItem.Name = "engToolStripMenuItem";
            this.engToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.engToolStripMenuItem.Text = "Eng";
            // 
            // русToolStripMenuItem
            // 
            this.русToolStripMenuItem.Name = "русToolStripMenuItem";
            this.русToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.русToolStripMenuItem.Text = "Рус";
            // 
            // укрToolStripMenuItem
            // 
            this.укрToolStripMenuItem.Name = "укрToolStripMenuItem";
            this.укрToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.укрToolStripMenuItem.Text = "Укр";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(9, 33);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(211, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bGCalendarToolStripMenuItem,
            this.bGSearchToolStripMenuItem,
            this.bGNotesToolStripMenuItem,
            this.bGPanelWithInstrumentToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // bGCalendarToolStripMenuItem
            // 
            this.bGCalendarToolStripMenuItem.Name = "bGCalendarToolStripMenuItem";
            this.bGCalendarToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.bGCalendarToolStripMenuItem.Text = "BG calendar";
            this.bGCalendarToolStripMenuItem.Click += new System.EventHandler(this.bGCalendarToolStripMenuItem_Click);
            // 
            // bGSearchToolStripMenuItem
            // 
            this.bGSearchToolStripMenuItem.Name = "bGSearchToolStripMenuItem";
            this.bGSearchToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.bGSearchToolStripMenuItem.Text = "BG search";
            this.bGSearchToolStripMenuItem.Click += new System.EventHandler(this.bGSearchToolStripMenuItem_Click);
            // 
            // bGNotesToolStripMenuItem
            // 
            this.bGNotesToolStripMenuItem.Name = "bGNotesToolStripMenuItem";
            this.bGNotesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.bGNotesToolStripMenuItem.Text = "BG notes";
            this.bGNotesToolStripMenuItem.Click += new System.EventHandler(this.bGNotesToolStripMenuItem_Click);
            // 
            // bGPanelWithInstrumentToolStripMenuItem
            // 
            this.bGPanelWithInstrumentToolStripMenuItem.Name = "bGPanelWithInstrumentToolStripMenuItem";
            this.bGPanelWithInstrumentToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.bGPanelWithInstrumentToolStripMenuItem.Text = "BG panel with instrument";
            this.bGPanelWithInstrumentToolStripMenuItem.Click += new System.EventHandler(this.bGPanelWithInstrumentToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save notes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 116);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Settings";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem укрToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGPanelWithInstrumentToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

