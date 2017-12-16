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
            getCoinInfo("xem");
            
        }
        void getCoinInfo(string coin)
        {
            using (WebClient wc = new WebClient())
            {
                string response = wc.DownloadString(link_getMarketSummary + coin);
                var jStr = JsonConvert.DeserializeObject<dynamic>(response);
                decimal last = jStr.result[0].Last;
                nameCoinFirstLbl.Text = "" + last;
            }
        }
        //update
        #region

        #endregion
    }
}
