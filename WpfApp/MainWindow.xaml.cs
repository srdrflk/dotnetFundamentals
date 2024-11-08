using ClassLibraryToHandle;
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
using System.Xml.Linq;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HelloWorldManager helloWorldManager = new HelloWorldManager();
            
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                var message = $"Hello, {txtName.Text}";

                MessageBox.Show(message);

                var handledMessage = helloWorldManager.GetHelloMessage(txtName.Text);
                MessageBox.Show($"{handledMessage}");

            }
            else
            {
                MessageBox.Show("Please write your name to the text box");
            }

        }
    }
}