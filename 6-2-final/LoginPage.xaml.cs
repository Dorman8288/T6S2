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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            SellerPassTB.Text = "MyShop1234$";
        }

        private void SellerLoginClick(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow.setCurrentUser(DataManager.login(SellerNameTB.Text, SellerPassTB.Text, LoginType.Seller));
                NavigationService.Navigate(new Uri("SellerPage.xaml", UriKind.Relative));
            }catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CustomerLoginClick(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow.setCurrentUser(DataManager.login(SellerNameTB.Text, SellerPassTB.Text, LoginType.Customer));
                NavigationService.Navigate(new Uri("SellerPage.xaml", UriKind.Relative));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TeacherLoginClick(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow.setCurrentUser(DataManager.login(SellerNameTB.Text, SellerPassTB.Text, LoginType.Teacher));
                NavigationService.Navigate(new Uri("SellerPage.xaml", UriKind.Relative));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void StudentLoginClick(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow.setCurrentUser(DataManager.login(SellerNameTB.Text, SellerPassTB.Text, LoginType.Student));
                NavigationService.Navigate(new Uri("SellerPage.xaml", UriKind.Relative));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
