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
        static Account currentUser = null;
        public static void setCurrentUser(Account user)
        {
            currentUser = user;
        }
        public static Account getCurrentUser()
        {
            return currentUser;
        }
        public MainWindow()
        {
            InitializeComponent();
            DataManager.LoadAll();
           
        }
        private void Exit(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DataManager.SaveAll();
        }
    }
}
