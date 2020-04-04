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

namespace BeyKarakoyWPF
{
    /// <summary>
    /// Interaction logic for TshirtWindow.xaml
    /// </summary>
    public partial class TshirtWindow : Window
    {
        WebOdevEntities data = new WebOdevEntities();
        public TshirtWindow()
        {
            InitializeComponent();
           
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }

        public void Load()
        {

            List<Category> categories = data.Categories.OrderBy(x => x.Name).ToList();
            ustMenu.ItemsSource = categories;
            cmbUst.ItemsSource = categories;
           
            Create();


        }

        private void Create()
        {

            //List<Product> products = data.Products.OrderBy(x => x.Name).ToList();
            //List<Product> data1 = (from a in data.Products.ToList()
            //                       select new Product
            //                       {
            //                           Name = a.Name
                                      
            //                       }).ToList();



            //prodGrid.Background = Brushes.Gray;

            //for (int i = 0; i < (10); i++)
            //{
            //    Grid grd = new Grid();
            //    grd.Width = 50;
            //    grd.Height = 80;
            //    grd.HorizontalAlignment = HorizontalAlignment.Left;
            //    grd.VerticalAlignment = VerticalAlignment.Top;
            //    Thickness margin = grd.Margin;
            //    margin.Top += 90;
            //    margin.Left += 60;
            //    grd.Margin = margin;
            //    grd.Background = Brushes.Blue;
            //    prodGrid.Children.Add(grd);

            //}

            
            //var data1 = data.Database.SqlQuery<Product>("SELECT Name FROM Product").ToList();
            //var data2 = data.Database.SqlQuery<Product>("SELECT Image FROM Product").ToList();

            //for (int i = 0; i < 4 ; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Grid grd = new Grid();
            //        grd.Width = 30;
            //        grd.Height = 50;

            //        Grid grid = new Grid();
            //        grid.Width = grid.Height = 10;
            //        Label lbl = new Label();
            //        lbl.Width = 10;
            //        lbl.Height = 5;
            //        grd.Background = Brushes.Black;

            //        prodGrid.Children.Add(grd);
            //        grid.Background = new ImageBrush(new BitmapImage(new Uri("data2")));
            //        grid.Background = Brushes.Gray;
            //        lbl.Content = products;
            //        lbl.Foreground = Brushes.Red;
            //        grd.Children.Add(grid);
            //        grd.Children.Add(lbl);

            //    }
            //}
        }

        private void cmbUst_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void cmbUst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ustMenu_Click_1(object sender, MouseEventArgs e)
        {
            Load();
            
        }
    }
}
