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


            //var categories = context.Categories.ToList();

            //for (int i = 0; i < categories.Count; i++)
            //{
            //    cmbUst.Items.Add(categories);
            //}



            //var data1 = context.GetData<Category>("SELECT * FROM Categories");
            //cmbUst.ItemsSource = data1;

            //System.Windows.Data.CollectionViewSource categoryViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("categoryViewSource")));
            //Load data by setting the CollectionViewSource.Source property:
            // categoryViewSource.Source = [generic data source]
        }
      
     
        private void cmbUst_MouseMove(object sender, MouseEventArgs e)
        {
            //List<Category> ust = context.Categories.ToList();
            //cmbUst.ItemsSource = ust;
        }

        private void cmbUst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //NavigationWindow win = new NavigationWindow();
            


            TshirtWindow Tshirt = new TshirtWindow();
            //MainWindow mainwindow = new MainWindow();

            //NavigationService nav = NavigationService.GetNavigationService(main);
            //var tsh = cmbUst.SelectedItem.ToString();
            if (cmbUst.SelectedItem.ToString() == "T-shirt")
            {


                //mainwindow.Content = "TshirtWindow.xaml";
                this.Visibility = Visibility.Hidden;
                Tshirt.Show();


                //win.Content = Tshirt;
                //win.Show();

                //nav.Navigate(Tshirt);               

            }

        }

      
        private void ustMenu_Click_1(object sender, RoutedEventArgs e)
        {
                       
            TshirtWindow tshirt = new TshirtWindow();
            //var selectedItem = getSelectedItem(ustMenu.ContextMenu.Items);
            //if (ustMenu.Items.IndexOf.)
            //{
            //    tshirt.Show();
            //}
        }
    }
}
