using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace tamrin_6_2_final.Dialogs
{
    /// <summary>
    /// Interaction logic for AddMedia.xaml
    /// </summary>
    public partial class AddMedia : Window
    {
        public AddMedia()
        {
            InitializeComponent();
        }
        private void Window_ContentRendered(object sender, EventArgs e)
        {
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {
            try
            {
                DataManager.AddMedia(new Book(BooknameTB.Text, double.Parse(BookPriceTB.Text), BookIDTB.Text, BookAuthorTB.Text, BookPublisherTB.Text));
                MessageBox.Show("Successfull", "state", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void AddMagazine(object sender, RoutedEventArgs e)
        {
            try 
            {
                DataManager.AddMedia(new Magazines(MagazinenameTB.Text, double.Parse(MagazinePriceTB.Text), MagazineIDTB.Text, int.Parse(MagazineNumberOfPages.Text), MagazinePublisher.Text));
                MessageBox.Show("Successfull", "state", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void AddVideo(object sender, RoutedEventArgs e)
        {
            try 
            {
                DataManager.AddMedia(new Videos(VideonameTB.Text, double.Parse(VideoPriceTB.Text), VideoIDTB.Text, int.Parse(VideoTime.Text), int.Parse(VideoNumberOfCd.Text)));
                MessageBox.Show("Successfull", "state", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
