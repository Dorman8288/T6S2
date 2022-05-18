using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.Json;

namespace tamrin_6_2_final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            source.Student test1 = new source.Student("am@gmail.com", "99999999");
            MessageBox.Show("yes");
            textblock.Text = JsonSerializer.Serialize(test1);
            source.Seller test2 = new source.Seller("ali@gmail.com");
            source.DataManager.SaveAll();
            
        }
    }
}
