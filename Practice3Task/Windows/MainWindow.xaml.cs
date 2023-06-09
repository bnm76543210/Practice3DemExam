﻿using System;
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
        public static Service service;
        public static MainWindow mainWindow;
        public static bool isAdmin = false;
        public MainWindow()
        {
            InitializeComponent();
            FillingList();
        }

        /// <summary>
        /// Заполнение listview
        /// </summary>
        public void FillingList()
        {
            Demo3PracticeTaskEntities db = new Demo3PracticeTaskEntities();
            List<Service> list = new List<Service>();
            foreach (Service service in db.Service)
            {
                if (service.Image.Count(c => c == '/' || c == char.Parse(@"\")) < 2)
                {
                    service.Image = "pack://application:,,,/Resources/" + service.Image;
                }
                list.Add(service);
            }
            myList.ItemsSource = list.ToList();
            Quantity.Content = (myList.Items.Count) + " из " + db.Service.ToList().Count;
            mainWindow = this;
        }

        /// <summary>
        /// Событие для фильтрации в Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilteringComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddAllFilters();
        }

        /// <summary>
        /// Событие для сортировки в Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddAllFilters();
        }

        /// <summary>
        /// Событие для поиска в TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            AddAllFilters();
            if (Search.Text == "0000" && isAdmin == false)
            {
                isAdmin = true;
                AddService.Visibility = Visibility.Visible;
                NearestEntry.Visibility = Visibility.Visible;
                MessageBox.Show("Вы перешли в режим администратора");
            }
        }

        /// <summary>
        /// Добавление услуги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddService_Click(object sender, RoutedEventArgs e)
        {
            service = null;
            Windows.AddService addService = new Windows.AddService();
            addService.ShowDialog();
        }

        /// <summary>
        /// Окно с записью на услуги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NearestEntry_Click(object sender, RoutedEventArgs e)
        {
            Windows.NearestEntries nearestEntries = new Windows.NearestEntries();
            nearestEntries.ShowDialog();
        }

        /// <summary>
        /// Добавление записи на услугу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAddClientToService(object sender, RoutedEventArgs e)
        {
            if (isAdmin == true)
            {
                Windows.RegistrationForTheService registrationForTheService = new Windows.RegistrationForTheService();
                service = (sender as Button).DataContext as Service;
                registrationForTheService.Show();
                registrationForTheService.TextBlockDuration.Text = "Длительность услуги: " + service.Duration.ToString();
                registrationForTheService.TextBlockName.Text = "Наименование услуги: " + service.Name.ToString();
                Demo3PracticeTaskEntities db = new Demo3PracticeTaskEntities();
                registrationForTheService.ComboBoxChooseClient.ItemsSource = db.Client.ToList();
                registrationForTheService.Show();
            }
            else
            {
                MessageBox.Show("Перейдите в режим администратора!");
            }
        }

        /// <summary>
        /// Удаление услуги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickRemove(object sender, RoutedEventArgs e)
        {
            if (isAdmin == true)
            {
                MessageBoxResult result = MessageBox.Show("Вы точно желаете удалить услугу?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    Demo3PracticeTaskEntities db = new Demo3PracticeTaskEntities();
                    Service currentService = (sender as Button).DataContext as Service;
                    Service element = db.Service.Where(serviceFind => serviceFind.Id == currentService.Id).FirstOrDefault();
                    if (element.ClientService.Count > 0)
                    {
                        MessageBox.Show("Вы не можете удалить эту услугу так как на неё есть запись!");
                        return;
                    }
                    db.Service.Remove(element);
                    db.SaveChanges();
                    AddAllFilters();
                    MessageBox.Show("Услуга была успешно удалена!");
                }
            }
            else
            {
                MessageBox.Show("Перейдите в режим администратора!");
            }
        }

        /// <summary>
        /// Изменение услуги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickChange(object sender, RoutedEventArgs e)
        {
            if (isAdmin == true)
            {
                service = (sender as Button).DataContext as Service;
                Windows.AddService addService = new Windows.AddService();
                addService.ShowDialog();
            }
            else
            {
                MessageBox.Show("Перейдите в режим администратора!");
            }
        }

        /// <summary>
        /// Функция фильтрации/сортировки/поиска
        /// </summary>
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
                sortedList = sortedList.Where(element => element.Name.Contains(Search.Text)).ToList();
            }
            foreach (Service service in sortedList)
            {
                if (service.Image.Count(c => c == '/' || c == char.Parse(@"\")) < 2)
                {
                    service.Image = "pack://application:,,,/Resources/" + service.Image;
                }
            }
            myList.ItemsSource = sortedList;
            Quantity.Content = (myList.Items.Count) + " из " + db.Service.ToList().Count;
        }
    }
}
