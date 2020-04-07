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
           
            List<Product> products = dataa.Products.OrderBy(x => x.Name).ToList();


            List<Product> data1 = (from a in dataa.Products.ToList()
                                   select new Product
                                   {
                                       Name = a.Name

                                   }).ToList();
            List<Product> data2 = (from a in dataa.Products.ToList()
                                   select new Product
                                   {
                                       Image = a.Image

                                   }).ToList();


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

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    //BitmapImage bitmap = new BitmapImage();
                    //Image img = new Image();
                    //bitmap.BeginInit();
                    //bitmap.UriSource = new Uri("https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png");
                    //bitmap.EndInit();
                    //img.Source = bitmap;
                    Label lbl = new Label();
                    lbl.Width = 150;
                    lbl.Height = 200;
                    lbl.Background = Brushes.Red;
                    //lbl.Background = new ImageBrush(data2);
                    Grid.SetRow(lbl, i);
                    Grid.SetColumn(lbl, j);
                    grd.Children.Add(lbl);
                    lbl.HorizontalContentAlignment = HorizontalAlignment.Center;
                    lbl.VerticalAlignment = VerticalAlignment.Top;


                    Label label = new Label();
                    label.Width = 200;
                    label.Height = 50;
                    label.Background = Brushes.Gray;
                    label.Content = data1;
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
