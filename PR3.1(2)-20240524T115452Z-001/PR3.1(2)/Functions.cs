using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR3._1
{
    internal class Functions
    {
        /// <summary>
        /// Создание матрицы
        /// </summary>
        public void CreateMatrix<T>(DataGridView dataGridView, int rows, int columns)
        {
            dataGridView.ColumnCount = columns;
            dataGridView.RowCount = rows;
        }
        /// <summary>
        /// Вывод матрицы
        /// </summary>
        public void DisplayMatrix<T>(DataGridView dataGridView1, DataGridView dataGridView2)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dataGridView2.Columns.Add(col.Clone() as DataGridViewColumn);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object[] newRow = new object[row.Cells.Count];
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    newRow[i] = row.Cells[i].Value;
                }
                dataGridView2.Rows.Add(newRow);
            }
        }
        /// <summary>
        /// Расчёт суммы в каждом столбце
        /// </summary>
        public void CalculateColumnSum<T>(DataGridView dataGridView, System.Windows.Forms.TextBox textBox)
        {
            textBox.Clear();
            int columnsCount = dataGridView.ColumnCount;
            int rowsCount = dataGridView.RowCount;
            for (int i = 0; i < columnsCount; i++)
            {
                double sum = 0;
                for (int j = 0; j < rowsCount; j++)
                {
                    if (dataGridView[i, j].Value != null)
                    {
                        sum += Convert.ToDouble(dataGridView[i, j].Value);
                    }
                }
                textBox.Text += $"Сумма по столбцу {i + 1}: {sum}\t\t";
            }
        }
        /// <summary>
        /// Нахождение номера столбца с минимальным значением
        /// </summary>
        public void FindColumnWithMinValue<T>(DataGridView dataGridView, System.Windows.Forms.TextBox textBox)
        {
            double minVal = Double.MaxValue;
            List<double> minCols = new List<double>();
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                double val = 0;
                for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    if (dataGridView.Rows[j].Cells[i].Value != null)
                    {
                        val += Convert.ToDouble(dataGridView.Rows[j].Cells[i].Value);
                    }
                }
                if (val < minVal)
                {
                    minVal = val;
                    minCols.Clear();
                    minCols.Add(i);
                }
                else if (val == minVal)
                {
                    minCols.Add(i);
                }
            }
            textBox.Text = String.Join("; ", minCols.Select(x => (x + 1).ToString()));
        }
    }
}
