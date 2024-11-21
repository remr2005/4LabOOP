using StressTest;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1_task4_
{
    /// <summary>
    /// MainWindow))))
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// массив для хранения результатов
        /// </summary>
        private TestCaseResult[] results = new TestCaseResult[10];
        /// <summary>
        /// тут идет инициализация
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// логика для ListBoxs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaterialList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(MaterialList.SelectedIndex != -1 ? $"Material: {(Material)MaterialList.SelectedIndex} " : "");
            stringBuilder.Append(CrossList.SelectedIndex != -1 ? $"Cross-section: {(CrossSection)CrossList.SelectedIndex} " : "");
            stringBuilder.Append(TestList.SelectedIndex != -1 ? $"Result: {(TestResult)TestList.SelectedIndex}" : "");
            Result.Content = stringBuilder.ToString();
        }
        /// <summary>
        /// Запуск кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunTests_Click(object sender, RoutedEventArgs e)
        {
            int pass_Count = 0;
            int fail_count = 0;
            reasonList.Items.Clear();
            for (int i = 0; i < 10; i++) 
            {
                results[i] = TestManager.GenerateResult();
                if (results[i].Result.Equals(TestResult.Pass)) { pass_Count += 1; continue; }
                fail_count += 1;
                reasonList.Items.Add(results[i].ReasonForFailure);
            }
            Pass_Count.Content = pass_Count;
            Fail_Count.Content = fail_count;
        }
    }
}
