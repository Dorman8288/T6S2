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
    /// Interaction logic for SearchMedia.xaml
    /// </summary>
    public partial class SearchMedia : Window
    {
        public SearchMedia()
        {
            InitializeComponent();
        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(DataManager.SearchMedia(IDTB.Text));
            }catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }        
        }
        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
