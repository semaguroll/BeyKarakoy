using BeyKarakoyWPF.Data;
using BeyKarakoyWPF.Model;
using Newtonsoft.Json;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        BeyKarakoyEntities data = new BeyKarakoyEntities();
        SetProducts set = new SetProducts();
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
            SetProducts set = new SetProducts();
            cmbUst.ItemsSource = set.GetAllCategories();
            //listsepet.ItemsSource = set.GetAllSepet();
            foreach (var item in api.GetUsers())
            {
                if(item.Lgn==true)
                {
                    pnlUser.Visibility = Visibility.Visible;
                    lblUser.Content = "Hoşgeldin " + item.Name + item.Surname;
                }
                else if (item.Lgn == false)
                {
                    pnlUser.Visibility = Visibility.Hidden;
                }
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
                   
                    UsersModel user = new UsersModel()
                    {
                        Id=item.Id,
                        Name = item.Name,
                        Surname = item.Surname,
                        Mail = item.Mail,
                        Password = item.Password,
                        Lgn = true
                    };
                    api.PutUser(user, item.Id);
                }
            }
        }
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            pnlUser.Visibility = Visibility.Hidden;           
            foreach (var item in api.GetUsers())
            {
                if (item.Lgn==true)
                {
                    UsersModel user = new UsersModel()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Surname = item.Surname,
                        Mail = item.Mail,
                        Password = item.Password,
                        Lgn = false
                    };
                    api.PutUser(user, item.Id);
                }                 
                
            }
        }
        //private void cmdUp_Click(object sender, RoutedEventArgs e)
        //{
        //    Button btn = e.OriginalSource as Button;
        //    var data = btn.DataContext as SepetModel;
        //}
        //private void cmdDown_Click(object sender, RoutedEventArgs e)
        //{
        //    Button btn = e.OriginalSource as Button;
        //    var data = btn.DataContext as SepetModel;
        //    HttpClient client = new HttpClient()
        //    {
        //        BaseAddress = new Uri("https://localhost:44366/")
        //    };
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    HttpResponseMessage response = new HttpResponseMessage();
        //    string deleteUri = "api/sepet/" + data.Id.ToString();
        //    var result = client.DeleteAsync(deleteUri).Result;
        //    listsepet.ItemsSource = set.GetAllSepet();
        //}
        //private void btnFinish_Click(object sender, RoutedEventArgs e)
        //{
        //    HttpClient client = new HttpClient()
        //    {
        //        BaseAddress = new Uri("https://localhost:44366/")
        //    };
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    HttpResponseMessage response = new HttpResponseMessage();
        //    var data = set.GetAllSepet();
        //    foreach (var item in data)
        //    {
        //        string deleteUri = "api/sepet/" + item.Id.ToString();
        //        var result = client.DeleteAsync(deleteUri).Result;
        //    }
        //    listsepet.ItemsSource = set.GetAllSepet();
        //}
    }

}
