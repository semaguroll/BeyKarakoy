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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BeyKarakoyWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        WebOdevEntities data = new WebOdevEntities();
        public Login()
        {
            InitializeComponent();
        }
        private void cmbUst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TshirtWindow Tshirt = new TshirtWindow();

            if (cmbUst.SelectedItem.ToString() == "T-shirt")
            {
                this.Visibility = Visibility.Hidden;
                Tshirt.Show();
            }
        }


        private void btnSepet_Click(object sender, RoutedEventArgs e)
        {
            //Storyboard sb = Resources["OpenMenu"] as Storyboard;

            //sb.Begin(slidegrd);
            Storyboard sbrd = Resources["OpenM"] as Storyboard;
            sbrd.Begin(slidegrid);

        }

        private void btnCross_Click(object sender, RoutedEventArgs e)
        {
            //Storyboard sb = Resources["CloseMenu"] as Storyboard;
            //sb.Begin(slidegrd);
            Storyboard sbrd = Resources["CloseM"] as Storyboard;
            sbrd.Begin(slidegrid);
        }


        private void btnLogo_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main.Show();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Visibility = Visibility.Hidden;
            login.Show();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow search = new SearchWindow();
            this.Visibility = Visibility.Hidden;
            search.Show();
        }

        private void btnNewUser_Click(object sender, RoutedEventArgs e)
        {
            NewUser newuser = new NewUser();
            this.Visibility = Visibility.Hidden;
            newuser.Show();
        }

        private void btnMainPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Category> categories = data.Categories.OrderBy(x => x.Name).ToList();
            cmbUst.ItemsSource = categories;
        }
    }

}
