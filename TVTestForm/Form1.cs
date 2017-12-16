using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace TVTestForm
{
    public partial class FormMain : Form
    {
        private static string link_getMarketSummary = "https://bittrex.com/api/v1.1/public/getmarketsummary?market=btc-";

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            GetCoinInfo(coin, ref last, ref bid, ref ask);
            coinName_first.Text = coin;
            coinLast_first.Text = "" + last;
            coinBid_first.Text = "" + bid;
            coinAsk_first.Text = "" + ask;           
        }
        #endregion

       
    }
}
