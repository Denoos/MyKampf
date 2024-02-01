using MyKampf;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyKampf
{
    public partial class MainWindow : Window
    {
        private TheVilager selectedVilager;

        public List<TheVilager> vilagers { get; set; }
        public TheVilager SelectedVilager
        {
            get => selectedVilager;
            set
            {
                selectedVilager = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            vilagers = new List<TheVilager>();

            vilagers.Add(new TheVilager
            {
                Name = "Archer",
                Product = "Silicium",
                CostInEmeralds = 12
            });
            vilagers.Add(new TheVilager
            {
                Name = "Buther",
                Product = "Porcky",
                CostInEmeralds = 24
            });
            DataContext = this;
        }
    }
}
