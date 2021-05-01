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
    public partial class FormTrade : Form
    {
        public FormTrade()
        {
            InitializeComponent();
        }

        private void FormTrade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTradeDataSet1.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.dbTradeDataSet1.Stocks);
            // TODO: This line of code loads data into the 'dbTradeDataSet1.Options' table. You can move, or remove it, as needed.
            this.optionsTableAdapter.Fill(this.dbTradeDataSet1.Options);

        }

        private void btn_tradeStock_Click(object sender, EventArgs e)
        {
            string InstrumentType = "Stock";
            double price;
            double quantity;

            if (double.TryParse(txt_Price.Text, out price) == false || price <= 0
                || double.TryParse(txt_Quantity.Text, out quantity) == false || quantity <=0)
            {
                MessageBox.Show("Invalid Inputs");
            }
            else
            {
                DateTime stamp = DateTime.Now;
                string instrument = drop_TradeStock.SelectedValue.ToString();
                if (radio_sell.Checked)
                    quantity = -1 * quantity;
                Trade new_StockTrade = new Trade
                {
                    Quantity = quantity,
                    TradePrice = price,
                    Timestamp = stamp,
                    InstrumentType = "Stock",
                    Instrument = instrument
                };

                Model1Container2 model1container = new Model1Container2();
                model1container.Trades.Add(new_StockTrade);
                model1container.SaveChanges();
                this.Close();
                
            }
        }
    }
}
