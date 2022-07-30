using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrawDataFromHowKteam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<MenuTreeItem> TreeItems = new ObservableCollection<MenuTreeItem>();
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
        #endregion
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
