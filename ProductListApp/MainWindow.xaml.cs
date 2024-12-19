using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace ProductListApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    ProductName = "Щетка-варежка",
                    Description = "Щетка-варежка True Touch для ухода за шерстью",
                    Manufacturer = "True Touch",
                    Price = 259.00,
                    Stock = 0,
                    ImagePath = "Images/brush_glove.png"
                },
                new Product
                {
                    ProductName = "Миска",
                    Description = "Миска Triol 9002/KIDP3211/30",
                    Manufacturer = "Triol",
                    Price = 385.00,
                    Stock = 17,
                    ImagePath = "Images/bowl.png"
                }
            };

            DataContext = this;
        }
    }
}
