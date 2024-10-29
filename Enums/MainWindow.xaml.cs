using StressTest;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Enums
{
    /// <summary>
    /// MainWindow))))
    /// </summary>
    public partial class MainWindow : Window
    {
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
            if (MaterialList.SelectedItem is ListBoxItem materialItem)
            {
                stringBuilder.Append($"Material: {(Material)Enum.Parse(typeof(Material), materialItem.Content.ToString())} ");
            }
            if (CrossList.SelectedItem is ListBoxItem crossSectionItem)
            {
                stringBuilder.Append($"Cross-section: {(CrossSection)Enum.Parse(typeof(CrossSection), crossSectionItem.Content.ToString())} ");
            }
            if (TestList.SelectedItem is ListBoxItem testResultItem)
            {
                stringBuilder.Append($"Result: {(TestResult)Enum.Parse(typeof(TestResult), testResultItem.Content.ToString())}");
            }
            Result.Content = stringBuilder.ToString();
        }
    }
}