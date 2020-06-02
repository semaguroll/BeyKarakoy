using BeyKarakoyWPF.Data;
using BeyKarakoyWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        BeyKarakoyEntities data = new BeyKarakoyEntities();
        RestAPI api = new RestAPI();
        public NewUser()
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
        private void newUserWindow_Loaded(object sender, RoutedEventArgs e)
        {
                var cat =api.GetCategories();
                cmbUst.ItemsSource = cat;
        }
        private void btnSignup_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Length > 20 || txtName.Text.Length == 0)
            {
                lblError.Content = "Adınızı tekrar düzenleyiniz";
            }
            else if (txtSurname.Text.Length > 20 || txtSurname.Text.Length == 0)
            {
                lblError.Content = "Soyadınızı tekrar düzenleyiniz";
            }
            else if (txtPassword.Text.Length > 20 || txtPassword.Text.Length == 0)
            {
                lblError.Content = "Şifrenizi tekrar düzenleyiniz";
            }
            else
            {
                User user = new User()
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    Mail = txtMail.Text,
                    Password = txtPassword.Text
                };
                var data = api.GetUsers();
                foreach (var item in data)
                {
                    if (item.Name==txtName.Text&&item.Surname==txtSurname.Text&&item.Mail==txtMail.Text&&item.Password==txtPassword.Text)
                    {
                        lblError.Content = "Böyle bir kayıt bulunmaktadır.Lütfen giriş yapınız";
                        HttpClient client = new HttpClient()
                        {
                            BaseAddress = new Uri("https://localhost:44366/")
                        };
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        HttpResponseMessage response = new HttpResponseMessage();
                        string deleteUri = "api/users/" + item.Id.ToString();
                        var result = client.DeleteAsync(deleteUri).Result;                       
                    }                    
                }
                api.PostUser(user);
            }
            Login login = new Login();
            this.Visibility = Visibility.Hidden;
            login.Show();

        }
        private void txtPassword_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Clear();
        }
        private void txtMail_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txtMail.Clear();
        }
        private void txtSurname_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txtSurname.Clear();
        }
        private void txtName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txtName.Clear();
        }
        private void btnLogo_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main.Show();
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow search = new SearchWindow();
            this.Visibility = Visibility.Hidden;
            search.Show();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Visibility = Visibility.Hidden;
            login.Show();
        }
        private void btnMainPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main.Show();
        }
    }
}
