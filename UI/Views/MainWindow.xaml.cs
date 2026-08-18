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
using UCL.QuizApp.Core;
using WpfApp1.Core.Repositories;
using WpfApp1.UI.ViewModels;
using Window.resources = WpfApp1.UI.Reso
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IQuestionRepository repo = new FileQuestionRepository();

            DataContext = new QuizViewModel(repo);
        }
    }
}