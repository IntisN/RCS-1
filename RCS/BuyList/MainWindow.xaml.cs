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
    //For ObservableCollection using
    using System.Collections.ObjectModel;
    //Allow to create output file - using "file"
    using System.IO;
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
            this.BuyListItemName.Text = "Lūdzu, ievadiet pirkumu!";
            //Hardcoding some text in ItemsControl from history
            var History = File.ReadAllLines(@".\Saraksts.txt");
            for (int i = 0; i < History.Length; i++)
            {
                var ReadFromHistoryFile = History[i];
                this.BuyItemsList.Add(ReadFromHistoryFile);
            }
            
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
            //Deleting everything from BuyItemsList
            this.BuyItemsList.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Write list from BuyItemsList to file
            File.WriteAllLines(@".\Saraksts.txt", this.BuyItemsList);
        }

        private void BuyListItemName_GotFocus(object sender, RoutedEventArgs e)
        {
            //Clean BuyListItemName when mouse is clicked in box
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= BuyListItemName_GotFocus;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Deleting lines from BuyItemsList or reject operation
            string SelectedItem = this.BuyItemsListControl.SelectedItems[0] as string;
            BuyItemsList.Remove(SelectedItem);
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Write list from BuyItemsList to file when closing app
            File.WriteAllLines(@".\Saraksts.txt", this.BuyItemsList);
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            //Write list from BuyItemsList to file when app is closed
            File.WriteAllLines(@".\Saraksts.txt", this.BuyItemsList);
        }
    }
}
