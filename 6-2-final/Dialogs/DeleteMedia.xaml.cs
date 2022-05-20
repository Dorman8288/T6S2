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
    /// Interaction logic for DeleteMedia.xaml
    /// </summary>
    public partial class DeleteMedia : Window
    {
        public DeleteMedia()
        {
            InitializeComponent();
        }
        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void DeleteMediaClick(object sender, RoutedEventArgs e)
        {
            try
            {
                DataManager.DeleteMedia(IDTB.Text);
                MessageBox.Show("Successfull", "state", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
