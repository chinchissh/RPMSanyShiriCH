using System;
using System.Windows.Forms;
using CalculateLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RPMSanyShiriCH
{
    public partial class MainForm : Form
    {
        // Экземпляр класса Calculations для выполнения вычислений
        private Calculations calculations;

        public MainForm()
        {
            InitializeComponent();
            calculations = new Calculations();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение значений x и epsilon из текстовых полей
                double x = double.Parse(xTextBox.Text);
                double epsilon = double.Parse(epsilonTextBox.Text);

                // Очистка списка результатов
                resultListBox.Items.Clear();

                // Вычисление и добавление результатов в список
                foreach (string item in calculations.CalculateSumSeries(x, epsilon))
                {
                    resultListBox.Items.Add(item);
                }
            }
            catch (FormatException)
            {
                // Отображение сообщения об ошибке в случае некорректного ввода числовых значений
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для x и epsilon.",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                // Отображение сообщения об ошибке в случае некорректных аргументов для вычислений
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Проверка наличия результатов для сохранения
            if (resultListBox.Items.Count == 0)
            {
                MessageBox.Show("Результаты не найдены. Пожалуйста, выполните вычисление.",
                    "Нет данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Диалоговое окно сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.Title = "Сохранить результаты";

            // Если пользователь выбрал место сохранения и имя файла
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Запись результатов в выбранный файл
                    using (var writer = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var item in resultListBox.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }

                    // Отображение сообщения об успешном сохранении
                    MessageBox.Show("Результаты успешно сохранены в файл.",
                        "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Отображение сообщения об ошибке при сохранении
                    MessageBox.Show("Ошибка при сохранении результатов: " + ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}