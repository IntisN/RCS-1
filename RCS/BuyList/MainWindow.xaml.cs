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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuyList
{
    using System.Collections.ObjectModel;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Adding string where all items will be saved
        public ObservableCollection<string> BuyItemsList = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();

            //Asking for adding some items
            this.BuyListItemName.Text = "Lūdzu, ievadiet pirkumu";
            //Hardcoding some text in ItemsControl
            this.BuyItemsList.Add("Āboli");
            this.BuyItemsList.Add("Bumbieri");
            //Add entered items to ItemsControl
            this.BuyItemsListControl.ItemsSource = this.BuyItemsList;
        }

        private void AddListItemButton_Click(object sender, RoutedEventArgs e)
        {
            //Get a value from text box
            string EnteredItemToBuy = this.BuyListItemName.Text;

            //Deleting everything from result
            this.BuyListItemName.Text = "";

            //Write received value in a TextBlock and add to ItemsControl list
            this.BuyItemName.Text = EnteredItemToBuy;
            this.BuyItemsList.Add(EnteredItemToBuy);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.BuyItemsList.Clear();
        }
    }
}
