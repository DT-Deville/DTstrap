using DTstrap.UI.ViewModels.Bootstrapper;

namespace DTstrap.UI.Elements.Bootstrapper
{
    /// <summary>
    /// Interaction logic for CustomDialog.xaml
    /// </summary>
    public partial class CustomDialog
    {
        public CustomDialog()
            : base()
        {
            InitializeComponent();

            _viewModel = new BootstrapperDialogViewModel(this);
            DataContext = _viewModel;
        }
    }
}
