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
    /// Interaction logic for Seller.xaml
    /// </summary>
    public partial class SellerPage : Page
    {
        public SellerPage()
        {
            InitializeComponent();
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            Dialogs.AddMedia inputDialog = new Dialogs.AddMedia();
            inputDialog.Show();
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            Dialogs.DeleteMedia inputDialog = new Dialogs.DeleteMedia();
            inputDialog.Show();
        }
    }
}
