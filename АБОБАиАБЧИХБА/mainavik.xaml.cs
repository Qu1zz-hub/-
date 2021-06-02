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
using System.Windows.Shapes;

namespace АБОБАиАБЧИХБА
{
    /// <summary>
    /// Логика взаимодействия для mainavik.xaml
    /// </summary>
    public partial class mainavik : Window
    {
        public mainavik()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nani = new MainWindow();
            nani.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            АБОБАиАБЧИХБА.больницаDataSet1 больницаDataSet1 = ((АБОБАиАБЧИХБА.больницаDataSet1)(this.FindResource("больницаDataSet1")));
            // Загрузить данные в таблицу таблица_о_пациентах. Можно изменить этот код как требуется.
            АБОБАиАБЧИХБА.больницаDataSet1TableAdapters.таблица_о_пациентахTableAdapter больницаDataSet1таблица_о_пациентахTableAdapter = new АБОБАиАБЧИХБА.больницаDataSet1TableAdapters.таблица_о_пациентахTableAdapter();
            больницаDataSet1таблица_о_пациентахTableAdapter.Fill(больницаDataSet1.таблица_о_пациентах);
            System.Windows.Data.CollectionViewSource таблица_о_пациентахViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("таблица_о_пациентахViewSource")));
            таблица_о_пациентахViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу таблица__о_сотрудниках. Можно изменить этот код как требуется.
            АБОБАиАБЧИХБА.больницаDataSet1TableAdapters.таблица__о_сотрудникахTableAdapter больницаDataSet1таблица__о_сотрудникахTableAdapter = new АБОБАиАБЧИХБА.больницаDataSet1TableAdapters.таблица__о_сотрудникахTableAdapter();
            больницаDataSet1таблица__о_сотрудникахTableAdapter.Fill(больницаDataSet1.таблица__о_сотрудниках);
            System.Windows.Data.CollectionViewSource таблица__о_сотрудникахViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("таблица__о_сотрудникахViewSource")));
            таблица__о_сотрудникахViewSource.View.MoveCurrentToFirst();
        }
    }
}
