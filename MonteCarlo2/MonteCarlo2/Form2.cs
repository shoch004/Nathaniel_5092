using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarlo2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void add_instrument(object sender, EventArgs e)
        {

            double steps = 100;
            double paths = 1000;
            double total_profit = 0;
            double total_delta = 0;
            double total_gamma = 0;
            double total_vega = 0;
            double total_theta = 0 ;
            double total_rho = 0;

            //find number of optiosn selected

            int num_options = 0;
            int instrument_count = dataInstruments.SelectedRows.Count;
            List<object[]> option_list = new List<object[]>();
            List<object[]> stock_list = new List<object[]>();
            string type;

            if (instrument_count < 1)
            {
                MessageBox.Show("Invalid Instrument Selection");
                return;
            }

            //change settings user changed defaults

            for (int i = 0; i < instrument_count; i++)
            {
                var drv = dataInstruments.SelectedRows[i].DataBoundItem as DataRowView;
                var row = drv.Row as DataRow;
                var val = row.ItemArray;

                type = (string)val[5];

                if (type == "Stock")
                {
                    stock_list.Add(val);
                }
                else
                {
                    option_list.Add(val);
                }
            }

                //get volatility from user input
                double volatility;
                if (double.TryParse(txtVolatility.Text, out volatility) == false || volatility <= 0) 
                { 
                    MessageBox.Show("Invalid Volatility Input");
                    return;
                }

            Model1Container2 model1Container = new Model1Container2();
            //price each option, aggregate greeks and P/L, update the trade table
            foreach (var option in option_list)
                {
                    //price = option.Price(option.Vol, option.Rate, option.Underlying, option.Strike, option.Tenor, paths, steps, random_matrix, antithetic, cv);

                    //If there is no T-Bill submited with the same tenor, use defailt 5% risk free rate
                    //need to query underlying price, tenor, rate
                    

                    // get underlying ticker, call/put, and strike
                    string instrument = (string)option[6];
                    MessageBox.Show(instrument);

                    
                }


            
            




            //var drv = dataInstruments.SelectedRows[0].DataBoundItem as DataRowView;
            //var row = drv.Row as DataRow;

            //val is an object array of all the attributes of the Options object.
            //var val = row.ItemArray;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTradeDataSet2.Trades' table. You can move, or remove it, as needed.
            this.tradesTableAdapter.Fill(this.dbTradeDataSet2.Trades);
            // TODO: This line of code loads data into the 'tradeToolDataSet.Trades' table. You can move, or remove it, as needed.
            //this.tradesTableAdapter.Fill(this.tradeToolDataSet.Trades);

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form stock_add = new FormAddStock();
            stock_add.Show();
        }

        private void historicalStockPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form priceHist_add = new FormAddPriceHist();
            priceHist_add.Show();
        }

        private void rateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rate_add = new FormAddRate();
            rate_add.Show();
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form option_add = new FormAddOptions();
            option_add.Show();
        }

        private void tradeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form trade_stock = new FormTrade();
            trade_stock.Show();
        }

        private void optionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form trade_option = new FormTradeOption();
            trade_option.Show();
        }

        private void dataInstruments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //this.tradesTableAdapter.Fill(this.tradesBindingSource1);
        }
    }
}
