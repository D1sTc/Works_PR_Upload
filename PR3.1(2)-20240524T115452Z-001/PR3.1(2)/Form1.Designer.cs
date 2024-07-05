namespace PR3._1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddRow = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.CreateMatrixBtn = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PrintMatrixBtn = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CalculateSumBtn = new System.Windows.Forms.Button();
            this.CalculateSum = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.FindMinColumnBtn = new System.Windows.Forms.Button();
            this.FindMinColumn = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Create)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Print)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.свойстваToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // рассчитатьToolStripMenuItem
            // 
            this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.рассчитатьToolStripMenuItem.Text = "Рассчитать сумму по каждому столбцу";
            this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.найтиToolStripMenuItem.Text = "Найти номер столбца с минимальным значением";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить всё";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Напишите матрицу любого типа:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddRow);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Controls.Add(this.CreateMatrixBtn);
            this.groupBox2.Controls.Add(this.Create);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 175);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создать:";
            // 
            // AddRow
            // 
            this.AddRow.BackColor = System.Drawing.Color.Aqua;
            this.AddRow.Location = new System.Drawing.Point(39, 71);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(140, 43);
            this.AddRow.TabIndex = 3;
            this.AddRow.Text = "Добавить строку";
            this.AddRow.UseVisualStyleBackColor = false;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Add.Location = new System.Drawing.Point(39, 120);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(140, 43);
            this.Add.TabIndex = 2;
            this.Add.Text = "Добавить столбец";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // CreateMatrixBtn
            // 
            this.CreateMatrixBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.CreateMatrixBtn.Location = new System.Drawing.Point(39, 22);
            this.CreateMatrixBtn.Name = "CreateMatrixBtn";
            this.CreateMatrixBtn.Size = new System.Drawing.Size(140, 43);
            this.CreateMatrixBtn.TabIndex = 1;
            this.CreateMatrixBtn.Text = "Создать";
            this.CreateMatrixBtn.UseVisualStyleBackColor = false;
            this.CreateMatrixBtn.Click += new System.EventHandler(this.CreateMatrixBtn_Click);
            // 
            // Create
            // 
            this.Create.AllowUserToAddRows = false;
            this.Create.BackgroundColor = System.Drawing.Color.Bisque;
            this.Create.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Create.ColumnHeadersVisible = false;
            this.Create.Location = new System.Drawing.Point(223, 22);
            this.Create.Name = "Create";
            this.Create.RowHeadersVisible = false;
            this.Create.Size = new System.Drawing.Size(236, 125);
            this.Create.TabIndex = 0;
            this.Create.Validating += new System.ComponentModel.CancelEventHandler(this.Create_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PrintMatrixBtn);
            this.groupBox3.Controls.Add(this.Print);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 151);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывести:";
            // 
            // PrintMatrixBtn
            // 
            this.PrintMatrixBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.PrintMatrixBtn.Location = new System.Drawing.Point(315, 59);
            this.PrintMatrixBtn.Name = "PrintMatrixBtn";
            this.PrintMatrixBtn.Size = new System.Drawing.Size(140, 43);
            this.PrintMatrixBtn.TabIndex = 1;
            this.PrintMatrixBtn.Text = "Вывести";
            this.PrintMatrixBtn.UseVisualStyleBackColor = false;
            this.PrintMatrixBtn.Click += new System.EventHandler(this.PrintMatrixBtn_Click);
            // 
            // Print
            // 
            this.Print.AllowUserToAddRows = false;
            this.Print.BackgroundColor = System.Drawing.Color.Bisque;
            this.Print.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Print.ColumnHeadersVisible = false;
            this.Print.Location = new System.Drawing.Point(39, 22);
            this.Print.Name = "Print";
            this.Print.RowHeadersVisible = false;
            this.Print.Size = new System.Drawing.Size(240, 123);
            this.Print.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CalculateSumBtn);
            this.groupBox4.Controls.Add(this.CalculateSum);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(12, 424);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 140);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Подсчёт суммы по кадому столбцу:";
            // 
            // CalculateSumBtn
            // 
            this.CalculateSumBtn.BackColor = System.Drawing.Color.Violet;
            this.CalculateSumBtn.Location = new System.Drawing.Point(315, 66);
            this.CalculateSumBtn.Name = "CalculateSumBtn";
            this.CalculateSumBtn.Size = new System.Drawing.Size(140, 43);
            this.CalculateSumBtn.TabIndex = 1;
            this.CalculateSumBtn.Text = "Расчитать";
            this.CalculateSumBtn.UseVisualStyleBackColor = false;
            this.CalculateSumBtn.Click += new System.EventHandler(this.CalculateSumBtn_Click);
            // 
            // CalculateSum
            // 
            this.CalculateSum.Location = new System.Drawing.Point(39, 36);
            this.CalculateSum.Multiline = true;
            this.CalculateSum.Name = "CalculateSum";
            this.CalculateSum.Size = new System.Drawing.Size(240, 98);
            this.CalculateSum.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FindMinColumnBtn);
            this.groupBox5.Controls.Add(this.FindMinColumn);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(12, 570);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(492, 95);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Номер столбца с минимальным значением:";
            // 
            // FindMinColumnBtn
            // 
            this.FindMinColumnBtn.BackColor = System.Drawing.Color.HotPink;
            this.FindMinColumnBtn.Location = new System.Drawing.Point(315, 35);
            this.FindMinColumnBtn.Name = "FindMinColumnBtn";
            this.FindMinColumnBtn.Size = new System.Drawing.Size(140, 43);
            this.FindMinColumnBtn.TabIndex = 1;
            this.FindMinColumnBtn.Text = "Найти";
            this.FindMinColumnBtn.UseVisualStyleBackColor = false;
            this.FindMinColumnBtn.Click += new System.EventHandler(this.FindMinColumnBtn_Click);
            // 
            // FindMinColumn
            // 
            this.FindMinColumn.Location = new System.Drawing.Point(39, 35);
            this.FindMinColumn.Multiline = true;
            this.FindMinColumn.Name = "FindMinColumn";
            this.FindMinColumn.Size = new System.Drawing.Size(240, 39);
            this.FindMinColumn.TabIndex = 0;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.ClearBtn.Location = new System.Drawing.Point(51, 671);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(140, 43);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Очистить всё";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Gold;
            this.ExitBtn.Location = new System.Drawing.Point(331, 671);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(140, 43);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(517, 726);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(533, 765);
            this.MinimumSize = new System.Drawing.Size(533, 765);
            this.Name = "Form1";
            this.Text = "Матрица";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Create)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Print)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button CreateMatrixBtn;
        private System.Windows.Forms.DataGridView Create;
        private System.Windows.Forms.DataGridView Print;
        private System.Windows.Forms.TextBox CalculateSum;
        private System.Windows.Forms.TextBox FindMinColumn;
        private System.Windows.Forms.Button PrintMatrixBtn;
        private System.Windows.Forms.Button CalculateSumBtn;
        private System.Windows.Forms.Button FindMinColumnBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

