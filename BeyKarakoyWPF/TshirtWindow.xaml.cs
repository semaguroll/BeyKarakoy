using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Net.Http;

namespace BeyKarakoyWPF
{
    /// <summary>
    /// Interaction logic for TshirtWindow.xaml
    /// </summary>
    public partial class TshirtWindow : Window
    {
        WebOdevEntities dataa = new WebOdevEntities();
        public TshirtWindow()
        {
            InitializeComponent();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            List<Category> categories = dataa.Categories.OrderBy(x => x.Name).ToList();
            cmbUst.ItemsSource = categories;
            Create();
        }





        private void cmbUst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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

        private void Create()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44331/");

            //List<Product> products = dataa.Products.OrderBy(x => x.Name).ToList();


            //List<Product> data1 = (from a in dataa.Products.ToList()
            //                       select new Product
            //                       {
            //                           Name = a.Name

            //                       }).ToList();
            //List<Product> data2 = (from a in dataa.Products.ToList()
            //                       select new Product
            //                       {
            //                           Image = a.Image

            //                       }).ToList();


            HttpResponseMessage response = client.GetAsync("api/products").Result;
            if (response.IsSuccessStatusCode)
            {


                var products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;


                Grid grd = new Grid();
                grd.ShowGridLines = true;
                grd.Width = 630;
                grd.HorizontalAlignment = HorizontalAlignment.Left;
                grd.VerticalAlignment = VerticalAlignment.Top;
                ColumnDefinition col1 = new ColumnDefinition();
                ColumnDefinition col2 = new ColumnDefinition();
                ColumnDefinition col3 = new ColumnDefinition();
                RowDefinition row1 = new RowDefinition();
                RowDefinition row2 = new RowDefinition();
                RowDefinition row3 = new RowDefinition();
                RowDefinition row4 = new RowDefinition();
                grd.ColumnDefinitions.Add(col1);
                grd.ColumnDefinitions.Add(col2);
                grd.ColumnDefinitions.Add(col3);
                row1.Height = new GridLength(300);
                row2.Height = new GridLength(300);
                row3.Height = new GridLength(300);
                row4.Height = new GridLength(300);
                grd.RowDefinitions.Add(row1);
                grd.RowDefinitions.Add(row2);
                grd.RowDefinitions.Add(row3);
                grd.RowDefinitions.Add(row4);
                prodPanel.Children.Add(grd);

                //var xi = (data1.Count / 3);
                //var yi = 0;



                var xi = (products.Count() / 3);
                var yi = 0;

                //foreach (var item in products)
                //{

                    for (int i = 0; i < xi; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                        var item = products.ToList()[yi];
                        //var itemm = data2[yi];
                        yi++;



                            BitmapImage bitmap = new BitmapImage();
                            Image img = new Image();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri("https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png");
                            bitmap.EndInit();
                            img.Source = bitmap;
                            Label lbl = new Label();
                            lbl.Width = 150;
                            lbl.Height = 200;
                            lbl.Background = Brushes.Black;
                            //lbl.Background = new ImageBrush(itemm.Image);
                            Grid.SetRow(lbl, i);
                            Grid.SetColumn(lbl, j);
                            grd.Children.Add(lbl);
                            lbl.HorizontalContentAlignment = HorizontalAlignment.Center;
                            lbl.VerticalAlignment = VerticalAlignment.Top;

                            Label label = new Label();
                            // label.Content = item;
                            label.Width = 200;
                            label.Height = 50;
                            label.Background = Brushes.Gray;
                            label.Content = item.Name;


                            Grid.SetRow(label, i);
                            Grid.SetColumn(label, j);
                            grd.Children.Add(label);
                            label.HorizontalContentAlignment = HorizontalAlignment.Center;
                            label.VerticalAlignment = VerticalAlignment.Bottom;
                            Thickness margin = label.Margin;
                            margin.Bottom = 20;
                            label.Margin = margin;




                        }
                    }

               //}
            }

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
    }
}
