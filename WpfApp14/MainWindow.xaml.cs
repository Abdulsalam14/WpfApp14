using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> users { get; set; } = new ObservableCollection<User> { };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }


        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            if (txtbx1.Text.Length > 0 && txtbx2.Text.Length > 0 && clndr.SelectedDate != null)
            {
                users.Add(new User(txtbx1.Text, txtbx2.Text, DateOnly.FromDateTime(clndr.SelectedDate.Value)));
                txtbx1.Clear();
                txtbx2.Clear();
                clndr.SelectedDate = null;
            }
            else MessageBox.Show("Invalid Argument", "Error", MessageBoxButton.OK);
        }

        private void bnt2_Click(object sender, RoutedEventArgs e)
        {
            if (listviw.SelectedValue is User u)
            {
                users.Remove(u);
            }
            else MessageBox.Show("No selected");
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            users.Clear();
        }
    }
}
