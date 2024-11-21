using System;
using System.Runtime.Intrinsics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Vector_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Earth Angular Velocity
        /// </summary>
        public double EarthAngularVelocity = 7.2921150 * Math.Pow(10, -5);
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
        /// Button for sum, sub, mul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Vector3D vector1 = new Vector3D(double.Parse(x1.Text), double.Parse(x2.Text), double.Parse(x3.Text));
                Vector3D vector2 = new Vector3D(double.Parse(y1.Text), double.Parse(y2.Text), double.Parse(y3.Text));
                Sum.Text = (vector1 + vector2).ToString();
                Sub.Text = (vector1 - vector2).ToString();
                Mul.Text = (vector1 * vector2).ToString();
                Equal.Text = (vector1 == vector2).ToString();
            }
            finally { }
        }
        /// <summary>
        /// Button for mul vector and number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Vector3D vector1 = new Vector3D(double.Parse(z1.Text), double.Parse(z2.Text), double.Parse(z3.Text));
                double num = double.Parse(Num.Text);
                Res_Num_Mul.Text = (num * vector1).ToString();
            }
            finally { }
        }
        /// <summary>
        /// Button for Corriolis 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                Vector3D EarthVector = new Vector3D(0, 0, EarthAngularVelocity);
                Vector3D vector1 = new Vector3D(double.Parse(V1.Text), double.Parse(V2.Text), double.Parse(V3.Text));
                double num = double.Parse(Weight.Text);
                CoriolisRes.Text = (-2 * num * EarthAngularVelocity * vector1).abs.ToString();
            }
            finally { }
        }
    }
}
