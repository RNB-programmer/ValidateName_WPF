using Newtonsoft.Json;
using System.Net.Http;
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

namespace ValidateName_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private const string JSON_PATH = "https://localhost:7166/api/Users";
        private HttpClient _httpClient;
        public MainWindow()
        {
            InitializeComponent();

            _httpClient = new HttpClient();
        }

        private async void GetDatabtn_Click(object sender, RoutedEventArgs e)
        {
            var response =await _httpClient.GetStringAsync(JSON_PATH);
            NameLv.ItemsSource = JsonConvert.DeserializeObject<List<User >> (response);
        }
    }
}