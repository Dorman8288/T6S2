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
    /// Interaction logic for SelectMediaDialog.xaml
    /// </summary>
    public partial class SelectMediaDialog : Window
    {
        public SelectMediaDialog()
        {
            InitializeComponent();
            MediaIC.ItemsSource = DataManager.getMediasName();
        }
        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SelectButtonClick(object sender, RoutedEventArgs e)
        {
            Media item = DataManager.FindMedia(NameTB.Text);
            if(MessageBox.Show($"Info:\n{item.info()}", "item", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                Account user = MainWindow.getCurrentUser();
                user.AddToCart(item);
            }
        }
    }
}
