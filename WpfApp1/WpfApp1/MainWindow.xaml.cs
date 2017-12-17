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
using System.Windows.Threading;
using System.Net;
using Newtonsoft.Json;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string link_getMarketSummary = "https://bittrex.com/api/v1.1/public/getmarketsummary?market=btc-";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        private void TimerTick(object sender, EventArgs e)
        {
            UpdateInfoFirst("XEM");
        }
        void GetCoinInfo(string coin, ref decimal last, ref decimal bid, ref decimal ask)
        {
            using (WebClient wc = new WebClient())
            {
                string response = wc.DownloadString(link_getMarketSummary + coin);
                var jStr = JsonConvert.DeserializeObject<dynamic>(response);
                last = jStr.result[0].Last;
                bid = jStr.result[0].Bid;
                ask = jStr.result[0].Ask;
            }
        }
        //update
        #region
        void UpdateInfoFirst(string coin)
        {
            decimal last = 0, bid = 0, ask = 0;

            decimal oldLast = Decimal.Parse(Convert.ToString(coinLast_first.Content));
            decimal oldBid =  Decimal.Parse(Convert.ToString(coinBid_first.Content));
            decimal oldAsk = Decimal.Parse(Convert.ToString(coinAsk_first.Content));

            GetCoinInfo(coin, ref last, ref bid, ref ask);

            coinName_first.Content = coin;
            coinLast_first.Content = "" + last;
            coinBid_first.Content = "" + bid;
            coinAsk_first.Content = "" + ask;

            if (oldLast > last)
                coinLast_first.Foreground = new SolidColorBrush(Colors.Red);
            else if (oldLast < last)
                coinLast_first.Foreground = new SolidColorBrush(Colors.Green);
            //else
            //    coinLast_first.Foreground = new SolidColorBrush(Colors.Black);

            if (oldBid > bid)
                coinBid_first.Foreground = new SolidColorBrush(Colors.Red);
            else if (oldBid < bid)
                coinBid_first.Foreground = new SolidColorBrush(Colors.Green);
            //else
            //    coinBid_first.Foreground = new SolidColorBrush(Colors.Black);

            if (oldAsk > ask)
                coinAsk_first.Foreground = new SolidColorBrush(Colors.Red);
            else if (oldAsk < ask)
                coinAsk_first.Foreground = new SolidColorBrush(Colors.Green);
            //else
            //    coinAsk_first.Foreground = new SolidColorBrush(Colors.Black);
        }
        #endregion
    }
}
