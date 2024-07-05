using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Создание матрицы
        /// </summary>
        private void CreateMatrixBtn_Click(object sender, EventArgs e)
        {
            Functions obj = new Functions();
            obj.CreateMatrix<double>(Create, 1, 1);
        }

        /// <summary>
        /// Вывод матрицы
        /// </summary>
        private void PrintMatrixBtn_Click(object sender, EventArgs e)
        {
            Functions obj = new Functions();
            obj.DisplayMatrix<double>(Create, Print);
        }

        /// <summary>
        /// Расчёт суммы в каждом столбце
        /// </summary>
        private void CalculateSumBtn_Click(object sender, EventArgs e)
        {
            Functions obj = new Functions();
            obj.CalculateColumnSum<double>(Create, CalculateSum);
        }

        /// <summary>
        /// Нахождение номера столбца с минимальным значением
        /// </summary>
        private void FindMinColumnBtn_Click(object sender, EventArgs e)
        {
            Functions obj = new Functions();
            obj.FindColumnWithMinValue<double>(Create, FindMinColumn);
        }

        /// <summary>
        /// Открытие окна с информацией о программе
        /// </summary>
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2(); 
            newF.Show();
        }

        /// <summary>
        /// Очистка всех полей
        /// </summary>
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Create.Rows.Clear();
            Create.Columns.Clear();
            Print.Rows.Clear();
            Print.Columns.Clear();
            CalculateSum.Clear();
            FindMinColumn.Clear();
            errorProvider1.Clear();
            errorProvider2.Clear();
        }

        /// <summary>
        /// Выход из программы
        /// </summary>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Очистка всех полей
        /// </summary>
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearBtn_Click(sender, e);
        }

        /// <summary>
        /// Вызод из программы
        /// </summary>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitBtn_Click(sender, e);
        }

        /// <summary>
        /// Добавление столбца
        /// </summary>
        private void Add_Click(object sender, EventArgs e)
        {
            Create.ColumnCount++;
        }

        /// <summary>
        /// Расчёт суммы в каждом столбце
        /// </summary>
        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateSumBtn_Click(sender, e);
        }

        /// <summary>
        /// Нахождение номера столбца с минимальным значением
        /// </summary>
        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindMinColumnBtn_Click(sender, e);
        }

        /// <summary>
        /// Вывод ошибки при неверном вводе
        /// </summary>
        private void Create_Validating(object sender, CancelEventArgs e)
        {
            foreach (DataGridViewRow row in Create.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (String.IsNullOrWhiteSpace(cell.Value?.ToString()))
                    {
                        errorProvider1.SetError(Create, "Значение ячейки не может быть пустым!");
                    }
                    else errorProvider1.Clear();
                }
            }
            foreach (DataGridViewRow row in Create.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !Double.TryParse(cell.Value.ToString(), out _))
                    {
                        errorProvider2.SetError(Create, "Введите пожалуйста число, а не слово!");
                    }
                    else errorProvider2.Clear();
                }
            }
        }

        /// <summary>
        /// Добавление новой строки
        /// </summary>
        private void AddRow_Click(object sender, EventArgs e)
        {
            Create.RowCount++;
        }
    }
}
