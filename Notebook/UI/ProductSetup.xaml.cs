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
using System.Windows.Shapes;

namespace migueladanrm.Notebook.UI
{
    /// <summary>
    /// Lógica de interacción para ProductSetup.xaml
    /// </summary>
    public partial class ProductSetup : Window
    {
        public ProductSetup()
        {
            InitializeComponent();
            LayoutDialogs.Visibility = Visibility.Collapsed;
        }
    }
}
