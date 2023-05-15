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

namespace Practice3Task
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Service> sortedList;
        public static MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            FillingList();
        }

        public void FillingList()
        {
            Demo3PracticeTaskEntities db = new Demo3PracticeTaskEntities();
            myList.ItemsSource = db.Service.ToList();
            Quantity.Content = (myList.Items.Count) + " из " + db.Service.ToList().Count;
            mainWindow = this;
        }

        private void FilteringComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddAllFilters();
        }

        private void SortingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddAllFilters();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            AddAllFilters();
        }

        private void AddService_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddService addService = new Windows.AddService();
            addService.ShowDialog();
        }

        private void NearestEntry_Click(object sender, RoutedEventArgs e)
        {
            Windows.NearestEntries nearestEntries = new Windows.NearestEntries();
            nearestEntries.ShowDialog();
        }

        private void ClickAddClientToService(object sender, RoutedEventArgs e)
        {

        }

        private void ClickRemove(object sender, RoutedEventArgs e)
        {

        }

        private void ClickChange(object sender, RoutedEventArgs e)
        {

        }

        public void AddAllFilters()
        {
            Demo3PracticeTaskEntities db = new Demo3PracticeTaskEntities();
            sortedList = db.Service.ToList();
            if (SortingBy.SelectedIndex == 1)
            {
                sortedList = sortedList.OrderByDescending(element => element.Cost).ToList();
            }
            if (SortingBy.SelectedIndex == 2)
            {
                sortedList = sortedList.OrderBy(element => element.Cost).ToList();
            }
            if (Filtering.SelectedIndex == 1)
            {
                sortedList = sortedList.Where(element => element.Discount >= 0 && element.Discount < 5).ToList();
            }
            if (Filtering.SelectedIndex == 2)
            {
                sortedList = sortedList.Where(element => element.Discount >= 5 && element.Discount < 15).ToList();
            }
            if (Filtering.SelectedIndex == 3)
            {
                sortedList = sortedList.Where(element => element.Discount >= 15 && element.Discount < 30).ToList();
            }
            if (Filtering.SelectedIndex == 4)
            {
                sortedList = sortedList.Where(element => element.Discount >= 30 && element.Discount < 70).ToList();
            }
            if (Filtering.SelectedIndex == 5)
            {
                sortedList = sortedList.Where(element => element.Discount >= 70 && element.Discount <= 100).ToList();
            }
            if (Search.Text != "")
            {
                sortedList = sortedList.Where(element => element.Name.Contains(Search.Text) || element.Name.Contains(Search.Text)).ToList();
            }
            myList.ItemsSource = sortedList;
            Quantity.Content = (myList.Items.Count) + " из " + db.Service.ToList().Count;
        }
    }
}
