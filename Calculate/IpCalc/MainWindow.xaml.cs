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
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IpCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();  
        }

        MessageForm mf = new MessageForm();
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (TextBox1.Text == String.Empty || TextBox1.Text == String.Empty || TextBox2.Text == String.Empty || TextBox3.Text == String.Empty || TextBox4.Text == String.Empty)
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Ошибка!");
            }
            else if(Convert.ToInt32(TextBox1.Text) < 0 || Convert.ToInt32(TextBox2.Text) < 0 || Convert.ToInt32(TextBox1.Text) < 0 || double.Parse(TextBox3.Text) < 0)
            {
                MessageBox.Show("Значения не могут быть отрицательными!","Ошибка");
            }
            else
            {
                var summ0 = TextBox1.Text;
                var srok0 = TextBox2.Text;
                var proc0 = TextBox3.Text;
                var per0 = TextBox4.Text;
                double summ = double.Parse(summ0) - double.Parse(per0);
                double srokm = double.Parse(srok0);
                double proc = double.Parse(proc0);
                if (RadioButton1.IsChecked == true)
                {

                    double es = proc / 12 / 100; //Ежемесечная ставка
                    double os = Math.Pow((1 + es), srokm); //общая ставка
                    double ep = summ * es * os / (os - 1); //ежемесячный платёж
                    double pch = summ * es; //Процентная часть
                    double och = ep - pch; //Основная часть
                    double pere = ep * srokm - summ; // Переплата
                   
                    mf.lbl1.Content = srokm + "месяцев";
                    mf.lbl2.Content = Math.Round(ep) + " ₽";
                    mf.lbl3.Content = Math.Round(pere) + " ₽";
                    mf.lbl4.Content = Math.Round(och) + " ₽";
                    mf.lbl5.Content = Math.Round(pch) + " ₽";
                    mf.Show();
                }
                else if (RadioButton2.IsChecked == true)
                {
                    double es = proc / 12 / 100; //Ежемесечная ставка
                    double os = Math.Pow((1 + es), srokm); //общая ставка
                    double och = summ / srokm; //погашение долга
                    double pch = summ * es; //Процентная часть
                    double ep = pch + och;// Ежемесячный платёж
                    double pere = ep * srokm - summ; // Переплата
                    mf.lbl1.Content = srokm + "месяцев";
                    mf.lbl2.Content = Math.Round(ep) + " ₽";
                    mf.lbl3.Content = Math.Round(pere) + " ₽";
                    mf.lbl4.Content = Math.Round(och) + " ₽";
                    mf.lbl5.Content = Math.Round(pch) + " ₽";
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Выберите только один тип!");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

       

        
    }
}
