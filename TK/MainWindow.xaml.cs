using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TK
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double task1 = ValidateInput(task1Box.Text, 10);
                double task2 = ValidateInput(task2Box.Text, 50);
                double task3 = ValidateInput(task3Box.Text, 30);
                double task4 = ValidateInput(task4Box.Text, 10);
                double totalScore = task1 + task2 + task3 + task4;
                string grade = CalculateGrade(totalScore);
                totalScoreText.Text = $"Общая сумма баллов: {totalScore}";
                gradeText.Text = $"Оценка: {grade}";
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);}
        }

        public double ValidateInput(string input, double maxScore)
        {
            if (!double.TryParse(input, out double score))
                throw new ArgumentException("Пожалуйста, введите числовое значение.");

            if (score < 0 || score > maxScore)
                throw new ArgumentException($"Баллы должны быть в диапазоне от 0 до {maxScore}.");

            return score;
        }

        public string CalculateGrade(double totalScore)
        {
            if (totalScore >= 70 && totalScore <= 100)
                return "5 (отлично)";
            else if (totalScore >= 40 && totalScore <= 69)
                return "4 (хорошо)";
            else if (totalScore >= 20 && totalScore <= 39)
                return "3 (удовлетворительно)";
            else if (totalScore >= 0 && totalScore <= 19)
                return "2 (неудовлетворительно)";
            else
                return "-";
        }
    }
}