using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTstrap.UI.ViewModels.Settings;

namespace DTstrap.UI.Elements.Settings.Pages
{
    /// <summary>
    /// Interaction logic for DTstrapPage.xaml
    /// </summary>
    public partial class DTstrapPage
    {
        public DTstrapPage()
        {
            DataContext = new DTstrapViewModel();
            InitializeComponent();
        }
    }
}
