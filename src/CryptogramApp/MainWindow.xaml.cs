namespace SleepingBearSystem.Cryptogram.CryptogramApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public MainWindow()
    {
        this.DataContext = this._viewModel;
        this.InitializeComponent();
    }

    private readonly CryptogramViewModel _viewModel = new();
}
