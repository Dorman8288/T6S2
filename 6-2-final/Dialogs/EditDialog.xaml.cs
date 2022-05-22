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
    /// Interaction logic for EditDialog.xaml
    /// </summary>
    public partial class EditDialog : Window
    {
        public EditDialog()
        {
            InitializeComponent();
            MediaIC.ItemsSource = MainWindow.getCurrentUser().getCartNames();
        }
        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow.getCurrentUser().removeFromCart(NameTB.Text);
            MessageBox.Show($"successfull", "removal", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
