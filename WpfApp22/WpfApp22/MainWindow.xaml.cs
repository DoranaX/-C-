using System;
using System.Linq;
using System.Windows;

namespace WpfApp22
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            // Получите данные из элемента TextBox
            string inputText = InputTextBox.Text;

            // Разделите строки и столбцы для создания двумерного массива
            string[] rows = inputText.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int rowCount = rows.Length;
            int columnCount = rows[0].Split(' ').Length;

            int[][] array = new int[rowCount][];
            for (int i = 0; i < rowCount; i++)
            {
                string[] values = rows[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                array[i] = new int[columnCount];
                for (int j = 0; j < columnCount; j++)
                {
                    array[i][j] = int.Parse(values[j]);
                }
            }

            // Отсортируйте элементы в каждой строке
            for (int i = 0; i < rowCount; i++)
            {
                Array.Sort(array[i]);
            }

            // Вычислите среднее арифметическое для каждой строки
            double[] averages = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                averages[i] = array[i].Average();
            }

            // Отсортируйте строки по среднему арифметическому
            Array.Sort(averages, array);

            // Выведите результат в элемент TextBox
            OutputTextBox.Text = string.Join("\n", array.Select(row => string.Join(" ", row)));
        }
    }
}