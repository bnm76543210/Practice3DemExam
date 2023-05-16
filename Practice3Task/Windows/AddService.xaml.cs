using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
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
    /// Логика взаимодействия для AddService.xaml
    /// </summary>
    public partial class AddService : Window
    {
        /// <summary>
        /// Лист для хранения данных по дополнительным фотографиям в listview
        /// </summary>
        public List<AdditionalImage> additionalImagesMain;

        /// <summary>
        /// Инициализация окна
        /// </summary>
        public AddService()
        {
            InitializeComponent();
            additionalImagesMain = new List<AdditionalImage>();
            if (MainWindow.service != null)
            {
                AddRedBtn.Content = "Редактировать услугу";
                AddRedTextBlock.Text = "Редактирование услуги";
                LoadData();
            }
        }

        /// <summary>
        /// Загрузка данных для редактирования
        /// </summary>
        public void LoadData()
        {
            additionalImagesMain.Clear();
            additionalImages.Items.Clear();
            Demo3PracticeTaskEntities db = new Demo3PracticeTaskEntities();
            Name.Text = MainWindow.service.Name;
            Duration.Text = MainWindow.service.Duration.ToString();
            Cost.Text = MainWindow.service.Cost.ToString();
            Discount.Text = MainWindow.service.Discount.ToString();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(MainWindow.service.Image, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageChoosedPhoto.Source = bitmap;
            foreach (AdditionalImage item in db.AdditionalImage)
            {
                if (item.ServiceId == MainWindow.service.Id)
                {
                    AdditionalImage additionalImage = new AdditionalImage();
                    additionalImage.Image = item.Image;
                    additionalImage.ServiceId = MainWindow.service.Id;
                    additionalImagesMain.Add(additionalImage);
                    additionalImages.Items.Add(additionalImage);
                }
            }
        }

        /// <summary>
        /// Выбор фото
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickChoosePhoto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                string path = ofd.FileName;
                string pathToAdd = System.IO.Path.Combine(Environment.CurrentDirectory, "Услуги школы");
                try
                {
                    File.Copy(path, pathToAdd);
                }
                catch
                {
                    
                }
                ImageChoosedPhoto.Source = new BitmapImage(new Uri(path));
                MessageBox.Show("Вы выбрали фото!");
            }
        }

        /// <summary>
        /// Добавление/редактирование услуги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAddService(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Cost.Text == "" || Discount.Text == "" || Duration.Text == "" || Name.Text == "" || ImageChoosedPhoto.Source == null)
                {
                    MessageBox.Show("Вы заполнили не все поля!");
                    return;
                }
                if (int.Parse(Duration.Text) > 240)
                {
                    MessageBox.Show("Длительность услуги не должна превышать четырёх часов!");
                    return;
                }
                Demo3PracticeTaskEntities db = new Demo3PracticeTaskEntities();
            if (AddRedBtn.Content.ToString() == "Добавить услугу")
            {
                Service serviceRepeat = db.Service.Where(element => element.Name == Name.Text).FirstOrDefault();
                if (serviceRepeat != null)
                {
                    MessageBox.Show("Услуга с таким наименованием уже есть в базе данных!");
                    return;
                }
                Service serviceToAdd = new Service();
                serviceToAdd.Name = Name.Text;
                serviceToAdd.Cost = int.Parse(Cost.Text);
                serviceToAdd.Duration = int.Parse(Duration.Text);
                serviceToAdd.Discount = int.Parse(Discount.Text);
                serviceToAdd.Image = ImageChoosedPhoto.Source.ToString();
                db.Service.Add(serviceToAdd);
                db.SaveChanges();
                foreach (AdditionalImage item in additionalImages.Items)
                {
                    AdditionalImage additionalImage = new AdditionalImage();
                    additionalImage.Image = item.Image;
                    additionalImage.ServiceId = serviceToAdd.Id;
                    db.AdditionalImage.Add(additionalImage);
                }
                db.SaveChanges();
                MessageBox.Show("Вы успешно добавили услугу");
                this.Close();
                MainWindow.mainWindow.AddAllFilters();
            }
            else
            {
                MainWindow.service.Name = Name.Text;
                MainWindow.service.Cost = int.Parse(Cost.Text);
                MainWindow.service.Duration = int.Parse(Duration.Text);
                MainWindow.service.Discount = int.Parse(Discount.Text);
                MainWindow.service.Image = ImageChoosedPhoto.Source.ToString();
                db.Service.AddOrUpdate(MainWindow.service);
                db.SaveChanges();
                foreach (AdditionalImage item in db.AdditionalImage)
                {
                    if (item.ServiceId == MainWindow.service.Id)
                    {
                        db.AdditionalImage.Remove(item);
                    }
                }
                db.SaveChanges();
                foreach (AdditionalImage item in additionalImagesMain)
                {
                    AdditionalImage additionalImage = new AdditionalImage();
                    additionalImage.Image = item.Image;
                    additionalImage.ServiceId = MainWindow.service.Id;
                    db.AdditionalImage.Add(additionalImage);
                }
                db.SaveChanges();
                MessageBox.Show("Вы успешно обновили услугу");
                this.Close();
                MainWindow.mainWindow.AddAllFilters();
            }
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены правильными типами данных");
            }
        }

        /// <summary>
        /// Добавление дополнительной фотографии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAdditionalPhoto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                string path = ofd.FileName;
                AdditionalImage additional = new AdditionalImage();
                additional.Image = path;
                additionalImagesMain.Add(additional);
                additionalImages.Items.Add(additional);
                MessageBox.Show("Вы добавили фото!");
            }
        }

        /// <summary>
        /// Вызов контекстного меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void additionalImages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem addToOrderMenuItem = new MenuItem();
            addToOrderMenuItem.Header = "Удалить изображение";
            addToOrderMenuItem.Click += RemoveFromListItem_Click;
            contextMenu.Items.Add(addToOrderMenuItem);
            additionalImages.ContextMenu = contextMenu;
        }

        /// <summary>
        /// Удаление изображения из листа и обновление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveFromListItem_Click(object sender, RoutedEventArgs e)
        {
            AdditionalImage additionalImage = (AdditionalImage)additionalImages.SelectedItem;
            additionalImagesMain.Remove(additionalImage);
            additionalImages.Items.Clear();
            foreach (AdditionalImage item in additionalImagesMain)
            {
                additionalImages.Items.Add(item);
            }
        }
    }
}
