using DTstrap.UI.ViewModels.Bootstrapper;

namespace DTstrap.UI.Elements.Bootstrapper
{
    /// <summary>
    /// Interaction logic for ClassicFluentDialog.xaml
    /// </summary>
    public partial class ClassicFluentDialog
    {
        public ClassicFluentDialog()
            : base()
        {
            InitializeComponent();

            _viewModel = new ClassicFluentDialogViewModel(this);
            DataContext = _viewModel;
        }
    }
}
