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

namespace Practice3Task.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationForTheService.xaml
    /// </summary>
    public partial class RegistrationForTheService : Window
    {
        /// <summary>
        /// Инициализация окна записи на услугу
        /// </summary>
        public RegistrationForTheService()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Запись клиента на услугу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAddClientToService(object sender, RoutedEventArgs e)
        {
            if (DatePickerDate.SelectedDate == null || ComboBoxChooseClient.SelectedItem == null || TextBoxTime.Text == "")
            {
                MessageBox.Show("Не все поля были заполнены!");
                return;
            }
            try
            {
                TimeSpan time = TimeSpan.Parse(TextBoxTime.Text);
            }
            catch
            {
                MessageBox.Show("Неверный тип данных для времени!");
                return;
            }
            Demo3PracticeTaskEntities db = new Demo3PracticeTaskEntities();
            ClientService clientService = new ClientService();
            clientService.ServiceId = MainWindow.service.Id;
            clientService.ClientId = (ComboBoxChooseClient.SelectedItem as Client).Id;
            clientService.ServiceTime = (DateTime)DatePickerDate.SelectedDate;
            clientService.ServiceTime = clientService.ServiceTime.Date + TimeSpan.Parse(TextBoxTime.Text);
            db.ClientService.Add(clientService);
            db.SaveChanges();
            MessageBox.Show("Вы успешно записали клиента на услугу!");
            this.Close();
        }

        /// <summary>
        /// Выход из окна записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
