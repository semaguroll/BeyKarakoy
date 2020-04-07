using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.Entity;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EO.Internal;
using System.Windows.Media.Animation;

namespace BeyKarakoyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        WebOdevEntities data = new WebOdevEntities();
        // CollectionViewSource categoryViewSource;
        //CollectionViewSource productViewSource;


        public MainWindow()
        {
            InitializeComponent();

            //categoryViewSource = ((CollectionViewSource)(FindResource("categoryViewSource")));
            ////productViewSource = ((CollectionViewSource)(FindResource("catProductsViewSource")));
            //DataContext = this;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            List<Category> categories = data.Categories.OrderBy(x => x.Name).ToList();
            cmbUst.ItemsSource = categories;
            cmbUst.Foreground = Brushes.Black;
        
        }
      
     
     

        private void cmbUst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            TshirtWindow Tshirt = new TshirtWindow();

            if (cmbUst.SelectedItem.ToString() == "T-shirt")
            {
                this.Visibility = Visibility.Hidden;
                Tshirt.Show();
            }


            //NavigationWindow win = new NavigationWindow();

            //MainWindow mainwindow = new MainWindow();

            //NavigationService nav = NavigationService.GetNavigationService(main);
            //var tsh = cmbUst.SelectedItem.ToString();


            //mainwindow.Content = "TshirtWindow.xaml";
            //win.Content = Tshirt;
            //win.Show();

            //nav.Navigate(Tshirt);               


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
    }
}
