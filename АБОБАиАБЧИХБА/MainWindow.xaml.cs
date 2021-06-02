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

namespace АБОБАиАБЧИХБА
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (log.Text.Length > 0)
            {
                if (pass.Password.Length > 0)
                {
                    mainavik win1 = new mainavik();
                    win1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Введите пароль!", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Введите логин!", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sas a1 = new sas();
            a1.Show();
            this.Close();
        }
    }
}
