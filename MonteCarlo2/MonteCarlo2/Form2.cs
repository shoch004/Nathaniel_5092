using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        //static random matrix
        public static double[,] matrix;
        //static rand NormRand and Random objects
        NormRand rand = new NormRand();
        Random rnd = new Random();

        //class for parameterized threadStart
        public class Params
        {
            public int index_start { get; set; }
            public int index_end { get; set; }

            public int m_steps { get; set; }
        }

        public void rand_matrix_thread(object a)
        {

            Params p = (Params)a;

            //bpx_muller method
            for (int i = p.index_start; i < p.index_end; i++)
            {
                for (int j = 0; j < p.m_steps; j++)
                {
                    lock (this)
                    {
                        double number1 = rnd.NextDouble();
                        double number2 = rnd.NextDouble();
                        double uniform1 = 1.0 - number1;
                        double uniform2 = 1.0 - number2;
                        double norm = Math.Sqrt(-2 * Math.Log(uniform1)) * Math.Cos(2 * Math.PI * uniform2);
                        matrix[i, j] = norm;
                    }

                }
                //this.BeginInvoke(myDelegate);
            }

        }

        private void add_instrument(object sender, EventArgs e)
        {

            int steps = 100;
            int paths = 1000;
            double total_profit = 0;
            double total_delta = 0;
            double total_gamma = 0;
            double total_vega = 0;
            double total_theta = 0 ;
            double total_rho = 0;

            //add the monte carlo settings here.

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

            bool succeed = int.TryParse(txt_Steps.Text, out steps);
            if (succeed && steps < 5)
            {
                MessageBox.Show("Steps Must be Greater than 4");
                return;
            }
            if (steps == 0)
            {
                steps = 100;
            }

            bool succeed1 = int.TryParse(txt_Paths.Text, out paths);
            if (succeed1 && paths < 5)
            {
                MessageBox.Show("Paths Must be Greater than 4");
                return;
            }

            if (paths == 0)
            {
                paths = 1000;
            }
            bool antithetic = true;
            bool cv = true;
            bool thread = true;

            //if the settings are altered then update them
            if (check_antithetic.Checked || check_controlVariate.Checked || check_multithread.Checked || steps != 100 || paths != 1000)
            {
                antithetic = check_antithetic.Checked;
                cv = check_controlVariate.Checked;
                thread = check_multithread.Checked;
            }






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
                    string[] option_aspects = instrument.Split('_');
                if (option_aspects.Length != 3)
                {
                    MessageBox.Show("Invalid Instrument Description for a Selected Instrument");
                    return;
                }
                string underlying_ticker = option_aspects[0];
                string call_put = option_aspects[1];
                double strike;
                double.TryParse(option_aspects[2], out strike);
                
                //get last historical price
                
               //get Stock Id from stock table first
                var query = from t in model1Container.Stocks
                            where t.Ticker == underlying_ticker
                            select t.Id;
                Int32 stock_id;
                try
                {
                    stock_id = (Int32)query.FirstOrDefault();
                }
                catch
                {
                    MessageBox.Show("Underlying Stock ID error");
                    return;
                }

         
                

                var spot_query = from p in model1Container.StockPrices
                                 orderby p.Date
                            where p.StockID == stock_id
                            select p.ClosePrice;

                
                double price = -1;
                foreach (double prices in spot_query)
                {
                    price = prices;
                }

                if (price <=0)
                {
                    MessageBox.Show("At least one underlying stock does not have a historical price");
                    return;
                }

                //get tenor
                double tenor;
                string cp = "";
                if (call_put == "C")
                {
                    cp = "Call";
                }
                else if (call_put == "P")
                {
                    cp = "Put";
                }
                //for range options
                else
                {
                    cp = null;
                }
                var tenor_query = from t in model1Container.Options
                                  where t.Underlying == underlying_ticker
                                  where t.Strike == strike
                                  where t.CallPut == cp
                                  select t.Tenor;

                tenor = tenor_query.FirstOrDefault();


                //get rate 
                var rate_query = from r in model1Container.TBills
                                 where r.Tenor == tenor
                                 select r.Rate;

                //units are in percentage
                double rate = rate_query.FirstOrDefault();

                //default value 5%
                if (rate == 0)
                {
                    rate = 5;
                }
                if (thread == true)
                {
                    // initialize random matrix with correct dimensions paths x steps
                    matrix = new double[paths, steps];

                    int coreCount = 2; //my computer has 2 but this code can be easily changed for more
                    //coreCount = Environment.Processors...

                    //create array of threads equal to number of cores
                    List<Thread> threads = new List<Thread>();
                    for (int i = 0; i < coreCount; i++)
                    {
                        threads.Add(new Thread(new ParameterizedThreadStart(rand_matrix_thread)));
                    }

                    Params p1 = new Params
                    {
                        index_start = 0,
                        index_end = paths / 2,
                        m_steps = steps

                    };
                    Params p2 = new Params
                    {
                        index_start = p1.index_end,
                        index_end = paths,
                        m_steps = steps
                    };
                    threads[0].Start(p1);
                    threads[1].Start(p2);
                    threads[0].Join();
                    threads[0].Join();

                }
                //no multithreading
                else
                {
                    NormRand rnd = new NormRand();
                    double[,] matrix = rnd.BoxMuller_Matrix(paths, steps);
                }

                //instatiate option
                string option_type = (string)option[5];
                bool is_call = true;
                Option inst_option;
                if (call_put == "C")
                {
                    is_call = true;
                }
                else
                {
                    is_call = false;
                }
                if (option_type == "European")
                {
                    inst_option = new European
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = price,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = is_call

                    };
                }
                else if (option_type == "Asian")
                {
                    inst_option = new Asian
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = price,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = is_call
                    };
                }
                else if (option_type == "BarrierDI")
                {
                    bool downIn = true;
                    bool downOut = false;
                    bool upIn = false;
                    bool upOut = false;
                    double barrier;

                    //query barrier
                    var barrier_query = from t in model1Container.Options
                                      where t.Underlying == underlying_ticker
                                      where t.Strike == strike
                                      where t.CallPut == cp
                                      select t.Barrier;

                    barrier = (double)barrier_query.FirstOrDefault();

                    inst_option = new Barrier
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = price,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = is_call,
                        down_in = downIn,
                        down_out = downOut,
                        up_in = upIn,
                        up_out = upOut,
                        barrier_value = barrier
                    };

                    
                }

                else if (option_type == "BarrieDO")
                {
                    bool downIn = false;
                    bool downOut = true;
                    bool upIn = false;
                    bool upOut = false;
                    double barrier;

                    //query barrier
                    var barrier_query = from t in model1Container.Options
                                        where t.Underlying == underlying_ticker
                                        where t.Strike == strike
                                        where t.CallPut == cp
                                        select t.Barrier;

                    barrier = (double)barrier_query.FirstOrDefault();

                    inst_option = new Barrier
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = price,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = is_call,
                        down_in = downIn,
                        down_out = downOut,
                        up_in = upIn,
                        up_out = upOut,
                        barrier_value = barrier
                    };


                }
                else if (option_type == "BarrierUI")
                {
                    bool downIn = false;
                    bool downOut = false;
                    bool upIn = true;
                    bool upOut = false;
                    double barrier;

                    //query barrier
                    var barrier_query = from t in model1Container.Options
                                        where t.Underlying == underlying_ticker
                                        where t.Strike == strike
                                        where t.CallPut == cp
                                        select t.Barrier;

                    barrier = (double)barrier_query.FirstOrDefault();

                    inst_option = new Barrier
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = price,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = is_call,
                        down_in = downIn,
                        down_out = downOut,
                        up_in = upIn,
                        up_out = upOut,
                        barrier_value = barrier
                    };


                }
                else if (option_type == "BarrierUO")
                {
                    bool downIn = false;
                    bool downOut = false;
                    bool upIn = false;
                    bool upOut = true;
                    double barrier;

                    //query barrier
                    var barrier_query = from t in model1Container.Options
                                        where t.Underlying == underlying_ticker
                                        where t.Strike == strike
                                        where t.CallPut == cp
                                        select t.Barrier;

                    barrier = (double)barrier_query.FirstOrDefault();

                    inst_option = new Barrier
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = price,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = is_call,
                        down_in = downIn,
                        down_out = downOut,
                        up_in = upIn,
                        up_out = upOut,
                        barrier_value = barrier
                    };


                }

                else if (option_type == "Digital")
                {
                    var rebate_query = from t in model1Container.Options
                                        where t.Underlying == underlying_ticker
                                        where t.Strike == strike
                                        where t.CallPut == cp
                                        select t.Rebate;

                    double rebate = (double)rebate_query.FirstOrDefault();

                    inst_option = new Digital
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = price,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = is_call,
                        rebate = rebate
                    };
                }

                else if (option_type == "Range")
                {
                    inst_option = new Range { 
                    
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = price,
                        Tenor = tenor,
                        Rate = rate / 100,
                        //is call does not matter for Range 
                        isCall = is_call
                    };
                }

                else
                {
                    MessageBox.Show("Option Type Not Recognized");
                    return;
                }

                //price option and calculate the greeks

                double[] option_price = inst_option.Price(inst_option.Vol, inst_option.Rate, inst_option.Underlying, inst_option.Strike, inst_option.Tenor, paths, steps, matrix, antithetic, cv);
                Dictionary<string, double> greeks = Greeks.Calculate(paths, steps, inst_option, matrix, antithetic, cv, option_price[0]);

                Int32 option_id = (Int32)option[0];

                //insert market price, delta and P/l in trade table

                var update_option = model1Container.Trades.SingleOrDefault(o => o.Id == option_id);
                if (update_option != null)
                {
                    update_option.MarketPrice = option_price[0];
                    update_option.PL = update_option.Quantity * (option_price[0] - update_option.TradePrice);
                    update_option.Delta = greeks["delta"] * update_option.Quantity;

                    model1Container.SaveChanges();
                }

                total_delta += greeks["delta"] * update_option.Quantity;
                total_gamma += greeks["gamma"] * update_option.Quantity;
                total_vega += greeks["vega"] * update_option.Quantity;
                total_theta += greeks["theta"] * update_option.Quantity;
                total_rho += greeks["rho"] * update_option.Quantity;
                total_profit += update_option.Quantity * (option_price[0] - update_option.TradePrice);

            }

        
            foreach (var stock in stock_list)
            {
                Int32 stock_id = (Int32)stock[0];

                var update_stock = model1Container.Trades.SingleOrDefault(s => s.Id == stock_id);
                if (update_stock != null)
                {
                    update_stock.Delta = update_stock.Quantity;

                    //get last historical date
                    //first get ticker
                    string stock_ticker = update_stock.Instrument;

                    //then get stock id from stock table
                    var queried_stock = model1Container.Stocks.SingleOrDefault(s => s.Ticker == stock_ticker);
                    //make id_stock an int32
                    //then get most recent price
                    var spot_query = from p in model1Container.StockPrices
                                     orderby p.Date
                                     where p.StockID == queried_stock.Id
                                     select p.ClosePrice;


                    double price = -1;
                    foreach (double prices in spot_query)
                    {
                        price = prices;
                    }
                    
                    if (price <= 0)
                    {
                        MessageBox.Show("At least one selected stock does not have a historical price");
                        return;
                    }

                    update_stock.MarketPrice = price;
                    update_stock.PL = update_stock.Quantity * (price - update_stock.TradePrice);

                    model1Container.SaveChanges();

                    total_delta += update_stock.Quantity;
                    total_profit += update_stock.Quantity * (price - update_stock.TradePrice);
                }
            }

            this.tradesTableAdapter.Fill(this.dbTradeDataSet2.Trades);
            dataTotals.Rows.Clear();
            dataTotals.Rows.Add(total_profit, total_delta, total_gamma, total_vega, total_theta, total_rho);


            
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
            this.tradesTableAdapter.Fill(this.dbTradeDataSet2.Trades);
        }
    }
}
