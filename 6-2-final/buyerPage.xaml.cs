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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tamrin_6_2_final
{
    /// <summary>
    /// Interaction logic for buyerPage.xaml
    /// </summary>
    public partial class buyerPage : Page
    {
        public buyerPage()
        {
            InitializeComponent();
        }
        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow.setCurrentUser(null);
            NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
        }
        private void SelectButtonClick(object sender, RoutedEventArgs e)
        {
            Dialogs.SelectMediaDialog inputDialog = new Dialogs.SelectMediaDialog();
            inputDialog.Show();
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            Dialogs.EditDialog inputDialog = new Dialogs.EditDialog();
            inputDialog.Show();
        }

        private void BuyClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"you should pay {MainWindow.getCurrentUser().CheckOut().ToString()}$", "state", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
