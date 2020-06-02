using BeyKarakoyWPF.Data;
using BeyKarakoyWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        BeyKarakoyEntities data = new BeyKarakoyEntities();
        RestAPI api = new RestAPI();
        public bool login { get; set; }
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
            Storyboard sbrd = Resources["OpenM"] as Storyboard;
            sbrd.Begin(slidegrid);
        }
        private void btnCross_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sbrd = Resources["CloseM"] as Storyboard;
            sbrd.Begin(slidegrid);
        }
        private void btnLogo_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main.Show();
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
             var cat =api.GetCategories();           
             cmbUst.ItemsSource = cat;
            if (login == true)
            {
                pnlUser.Visibility = Visibility.Visible;
            }
            else if (login == false)
            {
                pnlUser.Visibility = Visibility.Hidden;
            }
        }
        private void btnSearchPage_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow search = new SearchWindow();
            this.Visibility = Visibility.Hidden;
            search.Show();
        }
        private void btnLoginPage_Click(object sender, RoutedEventArgs e)
        {
            Login loginn = new Login();
            this.Visibility = Visibility.Hidden;
            loginn.Show();         
           
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in api.GetUsers())
            {
                if (item.Mail==txtMail.Text&&item.Password==txtSifre.Text)
                {
                    pnlUser.Visibility = Visibility.Visible;
                    lblUser.Content ="Hoşgeldin " + item.Name + item.Surname;
                    login = true;
                }
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            pnlUser.Visibility = Visibility.Hidden;
            txtMail.Clear();
            txtSifre.Clear();
            login = false;
        }
    }

}
