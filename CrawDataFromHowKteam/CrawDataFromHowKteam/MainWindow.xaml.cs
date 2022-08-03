using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CrawDataFromHowKteam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region properties
        string homePage = "https://howkteam.vn/";
        HttpClient httpClient = new HttpClient();
        ObservableCollection<MenuTreeItem> TreeItems = new ObservableCollection<MenuTreeItem>();
        HttpClientHandler handler;
        CookieContainer cookie = new CookieContainer();

        #endregion
        public MainWindow()
        {
            InitializeComponent();


            IniHttpClient();

            MenuTreeItem item1 = new MenuTreeItem()
            {
                Name = "Item1",
                URL = "https://howkteam.vn/",
                Items = new ObservableCollection<MenuTreeItem>()
                {
                    new MenuTreeItem{Name = "subitem1", URL="sadasdas"},
                    new MenuTreeItem{Name = "subitem1", URL="sadasdas"},
                    new MenuTreeItem{Name = "subitem1", URL="sadasdas"},
                    new MenuTreeItem{Name = "subitem1", URL="sadasdas"},
                    new MenuTreeItem{Name = "subitem1", URL="sadasdas"}
        }
            };
            MenuTreeItem item2 = new MenuTreeItem()
            {
                Name = "Item1",
                URL = "https://howkteam.vn/",
                Items = new ObservableCollection<MenuTreeItem>()
                {
                    new MenuTreeItem{Name = "subitem1", URL="sadasdas"},
                    new MenuTreeItem{Name = "subitem1", URL="sadasdas"},
                    new MenuTreeItem{Name = "subitem1", URL="sadasdas"},
                    new MenuTreeItem{Name = "subitem1", URL="sadasdas",
                        Items = new ObservableCollection<MenuTreeItem>(){
                    new MenuTreeItem{Name = "subsubitem1", URL="321312321" } } },
                    new MenuTreeItem{Name = "subitem1", URL="sadasdas"}
        }
            };

            AddItemIntoTreeViewItem(TreeItems, item1);
            AddItemIntoTreeViewItem(TreeItems, item2);

            treeMain.ItemsSource = TreeItems;
        }

        #region methods
        void AddItemIntoTreeViewItem(ObservableCollection<MenuTreeItem> root, MenuTreeItem node)
        {
            root.Add(node);
        }

        void IniHttpClient()
        {
            handler = new HttpClientHandler
            {
                CookieContainer = cookie,
                ClientCertificateOptions = ClientCertificateOption.Automatic,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                AllowAutoRedirect = true,
                UseDefaultCredentials = false
            };


            //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.5060.134 Safari/537.36 Edg/103.0.1264.77");

            httpClient = new HttpClient(handler);
            httpClient.BaseAddress = new Uri(homePage);
        }

        string CrawlDataFromURL(string url)
        {
            string html = "";


            html = httpClient.GetStringAsync(url).Result;
                
            return html;
        }

        void Crawl(string url)
        {
            //< h4(.*?) </ h4 >

            string htmlLearn = CrawlDataFromURL(url);

            string courseListKey = "<div class=\"col-md-6 col-lg-4 col-xl-3\">(.*?)<div class=\"text-warning font-size-sm\">";
            var CourseList = Regex.Matches(htmlLearn, courseListKey, RegexOptions.Singleline);
            foreach (var course in CourseList)
            {
                string courseName = Regex.Match(course.ToString(), "(?=title).*?(?=\">)").Value.Replace("title=\"", "");
                string name = "0";
            }
        }
        #endregion
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Crawl("learn");
        }
    }
}
