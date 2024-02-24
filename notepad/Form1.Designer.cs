namespace notepad
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевестиСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времяИДатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьЖирнымToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьКурсивомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьРазмерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьРазмерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.создатьОкноToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.перевестиСтрокуToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.скопироватьToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(74, 32);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // создатьОкноToolStripMenuItem
            // 
            this.создатьОкноToolStripMenuItem.Name = "создатьОкноToolStripMenuItem";
            this.создатьОкноToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.создатьОкноToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.создатьОкноToolStripMenuItem.Text = "Создать";
            this.создатьОкноToolStripMenuItem.Click += new System.EventHandler(this.новоеОкноToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.вставитьToolStripMenuItem.Text = "Вставить ";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.удалитьToolStripMenuItem.Text = "Удалить ";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // перевестиСтрокуToolStripMenuItem
            // 
            this.перевестиСтрокуToolStripMenuItem.Name = "перевестиСтрокуToolStripMenuItem";
            this.перевестиСтрокуToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.перевестиСтрокуToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.перевестиСтрокуToolStripMenuItem.Text = "Перевести строку";
            this.перевестиСтрокуToolStripMenuItem.Click += new System.EventHandler(this.перевестиСтрокуToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // скопироватьToolStripMenuItem
            // 
            this.скопироватьToolStripMenuItem.Name = "скопироватьToolStripMenuItem";
            this.скопироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.скопироватьToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.скопироватьToolStripMenuItem.Text = "Скопировать";
            this.скопироватьToolStripMenuItem.Click += new System.EventHandler(this.скопироватьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.темыToolStripMenuItem,
            this.времяИДатаToolStripMenuItem,
            this.ЦветToolStripMenuItem,
            this.выделитьЖирнымToolStripMenuItem,
            this.выделитьКурсивомToolStripMenuItem,
            this.увеличитьРазмерToolStripMenuItem,
            this.уменьшитьРазмерToolStripMenuItem});
            this.изменитьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(116, 32);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(437, 32);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // темыToolStripMenuItem
            // 
            this.темыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темнаяToolStripMenuItem,
            this.светлаяToolStripMenuItem});
            this.темыToolStripMenuItem.Name = "темыToolStripMenuItem";
            this.темыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.темыToolStripMenuItem.Size = new System.Drawing.Size(437, 32);
            this.темыToolStripMenuItem.Text = "Темы";
            // 
            // темнаяToolStripMenuItem
            // 
            this.темнаяToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.темнаяToolStripMenuItem.Name = "темнаяToolStripMenuItem";
            this.темнаяToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.темнаяToolStripMenuItem.Text = "Темная";
            this.темнаяToolStripMenuItem.Click += new System.EventHandler(this.темнаяToolStripMenuItem_Click);
            // 
            // светлаяToolStripMenuItem
            // 
            this.светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            this.светлаяToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.светлаяToolStripMenuItem.Text = "Светлая";
            this.светлаяToolStripMenuItem.Click += new System.EventHandler(this.светлаяToolStripMenuItem_Click);
            // 
            // времяИДатаToolStripMenuItem
            // 
            this.времяИДатаToolStripMenuItem.Name = "времяИДатаToolStripMenuItem";
            this.времяИДатаToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.времяИДатаToolStripMenuItem.Size = new System.Drawing.Size(437, 32);
            this.времяИДатаToolStripMenuItem.Text = "Время и дата";
            this.времяИДатаToolStripMenuItem.Click += new System.EventHandler(this.времяИДатаToolStripMenuItem_Click);
            // 
            // ЦветToolStripMenuItem
            // 
            this.ЦветToolStripMenuItem.Name = "ЦветToolStripMenuItem";
            this.ЦветToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.ЦветToolStripMenuItem.Size = new System.Drawing.Size(437, 32);
            this.ЦветToolStripMenuItem.Text = "Цвет";
            this.ЦветToolStripMenuItem.Click += new System.EventHandler(this.ЦветToolStripMenuItem_Click);
            // 
            // выделитьЖирнымToolStripMenuItem
            // 
            this.выделитьЖирнымToolStripMenuItem.Name = "выделитьЖирнымToolStripMenuItem";
            this.выделитьЖирнымToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.выделитьЖирнымToolStripMenuItem.Size = new System.Drawing.Size(437, 32);
            this.выделитьЖирнымToolStripMenuItem.Text = "Выделить жирным";
            this.выделитьЖирнымToolStripMenuItem.Click += new System.EventHandler(this.выделитьЖирнымToolStripMenuItem_Click);
            // 
            // выделитьКурсивомToolStripMenuItem
            // 
            this.выделитьКурсивомToolStripMenuItem.Name = "выделитьКурсивомToolStripMenuItem";
            this.выделитьКурсивомToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.выделитьКурсивомToolStripMenuItem.Size = new System.Drawing.Size(437, 32);
            this.выделитьКурсивомToolStripMenuItem.Text = "Выделить курсивом";
            this.выделитьКурсивомToolStripMenuItem.Click += new System.EventHandler(this.выделитьКурсивомToolStripMenuItem_Click);
            // 
            // увеличитьРазмерToolStripMenuItem
            // 
            this.увеличитьРазмерToolStripMenuItem.CheckOnClick = true;
            this.увеличитьРазмерToolStripMenuItem.Name = "увеличитьРазмерToolStripMenuItem";
            this.увеличитьРазмерToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.увеличитьРазмерToolStripMenuItem.Size = new System.Drawing.Size(437, 32);
            this.увеличитьРазмерToolStripMenuItem.Text = "Увеличить размер";
            this.увеличитьРазмерToolStripMenuItem.Click += new System.EventHandler(this.увеличитьРазмерToolStripMenuItem_Click);
            // 
            // уменьшитьРазмерToolStripMenuItem
            // 
            this.уменьшитьРазмерToolStripMenuItem.Name = "уменьшитьРазмерToolStripMenuItem";
            this.уменьшитьРазмерToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.уменьшитьРазмерToolStripMenuItem.Size = new System.Drawing.Size(437, 32);
            this.уменьшитьРазмерToolStripMenuItem.Text = "Уменьшить размер";
            this.уменьшитьРазмерToolStripMenuItem.Click += new System.EventHandler(this.уменьшитьРазмерToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(0, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 414);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светлаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem времяИДатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ЦветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьЖирнымToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьКурсивомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевестиСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьРазмерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьРазмерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скопироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

