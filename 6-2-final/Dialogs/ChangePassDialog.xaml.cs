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
    /// Interaction logic for ChangePassDialog.xaml
    /// </summary>
    public partial class ChangePassDialog : Window
    {
        public ChangePassDialog()
        {
            InitializeComponent();
        }
        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void ChangePassClick(object sender, RoutedEventArgs e)
        {
            Seller user = MainWindow.getCurrentUser() as Seller;
            try
            {
                user.changePassword(OldPassTB.Text, NewPasswordTB.Text);
                MessageBox.Show("Successfull", "state", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
