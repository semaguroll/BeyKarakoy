using BeyKarakoyWPF.Data;
using BeyKarakoyWPF.Model;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using EO.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace BeyKarakoyWPF
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        RestAPI api = new RestAPI();
        ObservableCollection<SepetModel> mySepet;
        public List<Sepett> Sepet;
        SetProducts set = new SetProducts();

        public DetailWindow()
        {
            InitializeComponent();

            SetProducts set = new SetProducts();
            cmbUst.ItemsSource = set.GetAllCategories();
        }
        public DetailWindow(ProductModel model, string ImageSrc, string NameSrc, string Show, string DescriptionSrc, string InfoSrc, int PriceSrc)
        {
            Uri uri = new Uri(ImageSrc, UriKind.Absolute);
            ImageSource imgSource = new BitmapImage(uri);
            InitializeComponent();
            btnId.DataContext = model;
            //btnId.TabIndex= Id;
            //btnId.BindingContext = e.Item;
            img.Source = imgSource;
            lblName.Content = NameSrc;
            //lblShow.Text = Show;
            lblDescription.Content = DescriptionSrc;
            lblInfo.Content = InfoSrc;
            lblPrice.Content = PriceSrc.ToString()+" - TL";
        }
        private void btnSepet_Click(object sender, RoutedEventArgs e)
        {
            //Storyboard sb = Resources["OpenMenu"] as Storyboard;
            //sb.Begin(slidegrd);
            Storyboard sbrd = Resources["OpenM"] as Storyboard;
            sbrd.Begin(slidegrid);

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

       
       
      
        private void btnId_Click(object sender, RoutedEventArgs e)
        {
            if (btnS.BorderBrush == Brushes.Black)
            {

            }

            
            lblSepetInfo.Visibility = Visibility.Visible;
            var mydetails = btnId.DataContext as ProductModel;           
            Sepett sepet = new Sepett()
            {
                //Id = mydetails.Id,
                Image = mydetails.ImageSrc.AbsoluteUri,
                Name = mydetails.NameSrc,
                Price = mydetails.PriceSrc,
                Count = 1,
                Size = "S"
            };
            api.PostSepet(sepet);
           
            listsepet.ItemsSource = set.GetAllSepet();
            Storyboard sbrd = Resources["OpenM"] as Storyboard;
            sbrd.Begin(slidegrid);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {        
            listsepet.ItemsSource = set.GetAllSepet();
        }

        private void btnCross_Click_1(object sender, RoutedEventArgs e)
        {
            lblSepetInfo.Visibility = Visibility.Visible;
            Storyboard sbrd = Resources["CloseM"] as Storyboard;
            sbrd.Begin(slidegrid);
        }
     
        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            lblSepetInfo.Visibility = Visibility.Visible;
            lblSepetInfo.Content = "Tüm 1 Kısa Kollu Renkli Desenli Gömlek - S sepetinizde";            
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
           
            Button btn = e.OriginalSource as Button;
            var data = btn.DataContext as SepetModel;
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44309/")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = new HttpResponseMessage();                       
            string deleteUri = "api/sepet/"+data.Id.ToString();
            var result = client.DeleteAsync(deleteUri).Result;
            listsepet.ItemsSource = set.GetAllSepet();
        }

        private void btnS_Click(object sender, RoutedEventArgs e)
        {
            Brush(btnM, btnL, btnXL, btnXXL);
            btnS.BorderBrush = Brushes.Black;
        }

        private void btnM_Click(object sender, RoutedEventArgs e)
        {
            Brush(btnS, btnL, btnXL, btnXXL);
            btnM.BorderBrush = Brushes.Black;
        }

        private void btnL_Click(object sender, RoutedEventArgs e)
        {
            Brush(btnM, btnS, btnXL, btnXXL);
            btnL.BorderBrush = Brushes.Black;
        }

        private void btnXL_Click(object sender, RoutedEventArgs e)
        {
            Brush(btnM, btnL, btnS, btnXXL);
            btnXL.BorderBrush = Brushes.Black;
        }

        private void btnXXL_Click(object sender, RoutedEventArgs e)
        {
            Brush(btnM, btnL, btnXL, btnS);
            btnXXL.BorderBrush = Brushes.Black;
        }
        private void Brush(Button btn1, Button btn2, Button btn3, Button btn4)
        {
            btn1.BorderBrush = Brushes.White;
            btn2.BorderBrush = Brushes.White;
            btn3.BorderBrush = Brushes.White;
            btn4.BorderBrush = Brushes.White;
        }
        private void BrushClick(Button btn1, Button btn2, Button btn3, Button btn4)
        {
            
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44309/")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = new HttpResponseMessage();            
            var data = set.GetAllSepet();
            foreach (var item in data)
            {
                string deleteUri = "api/sepet/" + item.Id.ToString();
                var result = client.DeleteAsync(deleteUri).Result;
            }
            listsepet.ItemsSource = set.GetAllSepet();
        }
    }
}

//HttpClient client = new HttpClient()
//{
//    BaseAddress = new Uri("https://localhost:44309/")
//};
//client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//HttpResponseMessage response = new HttpResponseMessage();
//var mydetails = btnId.DataContext as ProductModel;
////mySepet = new ObservableCollection<SepetModel>();
//Sepett sepet = new Sepett()
//{
//    //Id = item.Id,
//    Image = mydetails.ImageSrc.AbsoluteUri,
//    Name = mydetails.NameSrc,
//    Price = mydetails.PriceSrc,
//    Count= 2,
//    Size="S"
//};
////mySepet.Add(sepet);
////var deneme = mySepet as SepetModel;

//string json = JsonConvert.SerializeObject(sepet, Formatting.Indented);
//HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
//var result = client.PostAsync("api/sepet", content).Result;

//api.PostSepet(mySepet);
//SepetWindow sepet= new SepetWindow(mydetails.ImageSrc, mydetails.NameSrc, mydetails.Show, mydetails.DescriptionSrc, mydetails.InfoSrc, mydetails.PriceSrc));
