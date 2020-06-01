using BeyKarakoyWPF.Data;
using BeyKarakoyWPF.Model;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace BeyKarakoyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        BeyKarakoyEntities data = new BeyKarakoyEntities();
        public List<Product> Products;
        RestAPI api;
        

        public MainWindow()
        {
            InitializeComponent();           
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            SetProducts set = new SetProducts();
            cmbUst.ItemsSource = set.GetAllCategories();
            //var a = set.GetAllCategories();
            listdata.ItemsSource = set.GetAllProducts();
           
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

        private void btnLogo_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main.Show();
        }

        private void cmbUst_MouseEnter(object sender, MouseEventArgs e)
        {
            cmbUst.Foreground = Brushes.Black;
        }

        private void cmbUst_MouseLeave(object sender, MouseEventArgs e)
        {
            cmbUst.Foreground = Brushes.White;
        }

        private void listdata_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {  
            var mydetails = listdata.SelectedItem as ProductModel;
            DetailWindow detail = new DetailWindow(mydetails, mydetails.ImageSrc.ToString(), mydetails.NameSrc, mydetails.Show, mydetails.DescriptionSrc, mydetails.InfoSrc, mydetails.PriceSrc);
             //this.Visibility = Visibility.Hidden;
            detail.Show();




        }        
    }
}
