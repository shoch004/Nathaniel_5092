using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarlo2
{
    public partial class FormAddPriceHist : Form
    {
        public FormAddPriceHist()
        {
            InitializeComponent();
        }

        private void FormAddPriceHist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tradeToolDataSet1.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.tradeToolDataSet1.Stocks);

        }

       

        private void btn_StockPrice_Click(object sender, EventArgs e)
        {
            //error handle make sure date is chosen and in the past? 
            //date_ClosePrice.Value = DateTime.Now;

            string ticker = drop_stockPrice.SelectedValue.ToString();
            double closePrice;
            if (double.TryParse(txt_ClosePrice.Text, out closePrice) == false || closePrice <= 0 )
                MessageBox.Show("Invalid Inputs");
            else
            { 
                using (var model1Container = new Model1Container())
                {
                    var query = from t in model1Container.Stocks
                                where t.Ticker == ticker
                                select t.Id;

                    var query1 = from s in model1Container.Stocks
                                 where s.Ticker == ticker
                                 select s;
                    Stocks foreign_key = query1.FirstOrDefault();


                    var id = query.FirstOrDefault();

                    StockPrices new_price = new StockPrices
                    {

                        ClosePrice = closePrice,
                        Date = date_ClosePrice.Value.Date,
                        StockID = (int)id,
                        Stock = foreign_key
                       
                    };
                    model1Container.StockPrices.Add(new_price);
                    model1Container.SaveChanges();

                }
            }
            

            //var stock_id = model1Container.Stocks.SqlQuery("SELECT Id FROM dbo.Stocks WHERE Ticker = @ticker", new SqlParameter("ticker", ticker)).ToList<Stocks>();

            //var stock_id = model1Container.Stocks.SqlQuery("SELECT Id FROM dbo.Stocks").ToList<Stocks>();
            //MessageBox.Show(stock_id.First<Stocks>().Id.ToString());
            //DateTime date = date_ClosePrice.Value.Date;
            //double closePrice;
            
            

            
        }
    }
}
