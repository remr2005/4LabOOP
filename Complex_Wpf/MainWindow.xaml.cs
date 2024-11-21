using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Complex_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// First Complex Number
        /// </summary>
        private Complex compl1;
        /// <summary>
        /// Second Complex Number
        /// </summary>
        private Complex compl2;
        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// TxtBox checker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // преобразовываем объект посылающий событие в TextBox
            TextBox? txt = sender as TextBox;
            // если преобразование успешно
            if (txt != null)
            {
                // проверяем можно ли спарсить введенный текст
                e.Handled = !double.TryParse(e.Text + txt.Text, out _);
            }
        }
        /// <summary>
        /// When Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            compl1 = new Complex(double.Parse(Rel1.Text), double.Parse(Img1.Text));
            compl2 = new Complex(double.Parse(Rel2.Text), double.Parse(Img2.Text));
            Exp1.Text = FromExpToString(compl1);
            Exp2.Text = FromExpToString(compl2);
            Sum.Text = (compl1 + compl2).ToString();
            Sub.Text = (compl1 - compl2).ToString();
            Mul.Text = (compl1 * compl2).ToString();
            Div.Text = (compl1 / compl2).ToString();
            SumE.Text = FromExpToString(compl1 + compl2);
            SubE.Text = FromExpToString(compl1 - compl2);
            MulE.Text = FromExpToString(compl1 * compl2);
            DivE.Text = FromExpToString(compl1 / compl2);
        }
        /// <summary>
        /// From exp to string
        /// </summary>
        /// <param name="exp"></param>
        /// <returns>String</returns>
        private string FromExpToString(Complex exp)
        {
            var obg1 = Complex.ToExp(exp);
            return $"{obg1.Item1}*e^(i{obg1.Item2})";
        }
    }
}
