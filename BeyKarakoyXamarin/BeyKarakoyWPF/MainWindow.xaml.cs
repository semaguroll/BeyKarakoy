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
using System.Windows.Media.Animation;
using System.Net.Http;

namespace BeyKarakoyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        WebOdevEntities data = new WebOdevEntities();
       
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            //List<Category> categories = data.Categories.OrderBy(x => x.Name).ToList();
            //cmbUst.ItemsSource = categories;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44331/");
            HttpResponseMessage response = client.GetAsync("api/categories").Result;
            if (response.IsSuccessStatusCode)
            {
                var categories = response.Content.ReadAsAsync<IEnumerable<Category>>().Result;
                //var item = categories.ToList()[i];
                cmbUst.ItemsSource = categories;
            }

            Create();


        }

        private void Create()
        {


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44331/");

            HttpResponseMessage response = client.GetAsync("api/products").Result;
            if (response.IsSuccessStatusCode)
            {


                var products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;


                Grid grd = new Grid();
                grd.ShowGridLines = false;
                grd.Width = 1000;
                grd.HorizontalAlignment = HorizontalAlignment.Left;
                grd.VerticalAlignment = VerticalAlignment.Top;
                ColumnDefinition col1 = new ColumnDefinition();
                ColumnDefinition col2 = new ColumnDefinition();
                ColumnDefinition col3 = new ColumnDefinition();
                RowDefinition row1 = new RowDefinition();
                RowDefinition row2 = new RowDefinition();
                RowDefinition row3 = new RowDefinition();        
                grd.ColumnDefinitions.Add(col1);
                grd.ColumnDefinitions.Add(col2);
                grd.ColumnDefinitions.Add(col3);
                row1.Height = new GridLength(400);
                row2.Height = new GridLength(400);
                row3.Height = new GridLength(400);               
                grd.RowDefinitions.Add(row1);
                grd.RowDefinitions.Add(row2);
                grd.RowDefinitions.Add(row3);              
                prodPanell.Children.Add(grd);

                //var xi = (data1.Count / 3);
                //var yi = 0;

                var xi = (products.Count() / 3);
                var yi = 0;

                //foreach (var item in products)
                //{

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        var item = products.ToList()[yi];
                        //var itemm = data2[yi];
                        yi++;


                        Image img = new Image();

                        Uri uri = new Uri(item.Image, UriKind.Absolute);
                        ImageSource imgSource = new BitmapImage(uri);

                        //BitmapImage bitmap = new BitmapImage();

                        //bitmap.BeginInit();
                        //bitmap.UriSource = new Uri(item.Image, UriKind.Absolute);
                        //bitmap.EndInit();
                        //img.Source = bitmap;
                        img.Source = imgSource;
                        Label lbl = new Label();
                        lbl.Width = 250;
                        lbl.Height = 300;
                        //lbl.Background = Brushes.Black;
                        lbl.Background = new ImageBrush(img.Source);
                        Grid.SetRow(lbl, i);
                        Grid.SetColumn(lbl, j);
                        grd.Children.Add(lbl);
                        lbl.HorizontalContentAlignment = HorizontalAlignment.Center;
                        lbl.VerticalAlignment = VerticalAlignment.Top;






                        Label label = new Label();
                        // label.Content = item;
                        label.Width = 200;
                        label.Height = 50;
                        label.Background = Brushes.Transparent;
                        label.Content = item.Name + " - " + item.Price;


                        Grid.SetRow(label, i);
                        Grid.SetColumn(label, j);
                        grd.Children.Add(label);
                        label.HorizontalContentAlignment = HorizontalAlignment.Center;
                        label.VerticalAlignment = VerticalAlignment.Bottom;
                        Thickness margin = label.Margin;
                        margin.Bottom = 20;
                        label.Margin = margin;



                        Label labell = new Label();
                        labell.Width = 50;
                        labell.Height = 50;
                        labell.Background = Brushes.Transparent;
                        labell.Content = "BEY";
                        labell.Foreground = Brushes.Gray;
                        Grid.SetRow(labell, i);
                        Grid.SetColumn(labell, j);
                        grd.Children.Add(labell);
                        labell.HorizontalContentAlignment = HorizontalAlignment.Center;
                        labell.VerticalAlignment = VerticalAlignment.Bottom;


                    }
                }

                //}
            }

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

        private void cmbUst_MouseEnter(object sender, MouseEventArgs e)
        {
            cmbUst.Foreground = Brushes.Black;
        }

        private void cmbUst_MouseLeave(object sender, MouseEventArgs e)
        {
            cmbUst.Foreground = Brushes.White;
        }
    }
}
