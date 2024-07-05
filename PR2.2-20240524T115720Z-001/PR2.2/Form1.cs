using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InputText.Validating += InputText_Validating;
        }
        /// <summary>
        /// Нахождение редкого слова
        /// </summary>
        private void BtnRarestWord_Click(object sender, EventArgs e)
        {
            string inputText = InputText.Text.ToLower(); // Преобразуем входную строку в нижний регистр
            char[] signs = new char[] {' ', ',', '.', ':', ';', '!', '?'}; // Знаки препинания, которые будем игнорировать
            string[] words = inputText.Split(signs, StringSplitOptions.RemoveEmptyEntries); // Разбиваем строку на массив слов
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            // Считаем количество каждого слова
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount.Add(word, 1);
            }
            int minCount = Int32.MaxValue;
            string rarestWord = null;
            foreach (KeyValuePair<string, int> pair in wordCount)
            {
                if (pair.Value < minCount)
                {
                    minCount = pair.Value;
                    rarestWord = pair.Key;
                }
                else if (pair.Value == minCount && String.Compare(pair.Key, rarestWord) < 0)
                    rarestWord = pair.Key;
            }
            OutputText.Text = rarestWord;
        }

        /// <summary>
        /// Очистка полей ввода и вывода
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            InputText.Clear();
            OutputText.Clear();
        }

        /// <summary>
        /// Закрытие программы
        /// </summary>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// При нажатии на кнопку выводится редкое слово
        /// </summary>
        private void вывестиРедкоеСловоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnRarestWord_Click(sender, e);
        }

        /// <summary>
        /// Очистка полей ввода и вывода
        /// </summary>
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnClear_Click(sender, e);
        }

        /// <summary>
        /// Закрытие программы
        /// </summary>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnExit_Click(sender, e);
        }

        /// <summary>
        /// Открытие окна со сведениями о программе
        /// </summary>
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2(); // создание объекта класса Form2
            newF.Show(); // открытие формы newF
        }

        /// <summary>
        /// Вывод ошибки при неверном вводе
        /// </summary>
        private void InputText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(InputText.Text))
            {
                errorProvider1.SetError(InputText, "Вы ничего не ввели!");
            }
            else errorProvider1.Clear(); // очищаем сообщения об ошибках
            string input = InputText.Text;
            if (input.Any(char.IsDigit))
            {
                errorProvider2.SetError(InputText, "Пожалуйста, введите слово, а не число!");
            }
            else errorProvider2.Clear(); // очищаем сообщения об ошибках
        }
    }
}
