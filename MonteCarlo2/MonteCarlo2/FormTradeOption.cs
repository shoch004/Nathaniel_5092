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
    public partial class FormTradeOption : Form
    {
        public FormTradeOption()
        {
            InitializeComponent();
        }

        private void FormTradeOption_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTradeDataSet1.Options' table. You can move, or remove it, as needed.
            this.optionsTableAdapter.Fill(this.dbTradeDataSet1.Options);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.optionsTableAdapter.FillBy(this.dbTradeDataSet1.Options);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_LoadOptions_Click(object sender, EventArgs e)
        {
            //Model1Container2 model1Container = new Model1Container2();
            //data_Options.
        }

        private void btn_TradeOption_Click(object sender, EventArgs e)
            
        {
             
            DataGridViewSelectedRowCollection selected_option = data_Options.SelectedRows;
            if (selected_option.Count != 1)
            {
                MessageBox.Show("Invalid Option Selection");
            }
            else
            {
                //Options option_trade;
                var drv = data_Options.SelectedRows[0].DataBoundItem as DataRowView;
                var row = drv.Row as DataRow;

                //val is an object array of all the attributes of the Options object.
                var val = row.ItemArray;

                string type = (string)val[0];
                string call_put;
                string call_put_abrev;
                string underlying_ticker = (string)val[2];
                double tenor = (double)val[3];
                double strike = (double)val[6];
                double rebate;
                double barrier;

                if (val[1] is System.DBNull)
                    call_put = "";
                else
                    call_put = (string)val[1];

                if (val[4] is System.DBNull)
                    rebate = -1;
                
                else 
                    rebate = (double)val[4];

                if (val[5] is System.DBNull)
                    barrier = -1;
                else
                    barrier = (double)val[5];

                double quantity;
                double price;
                if (double.TryParse(txt_Quantity.Text, out quantity) == false || quantity <= 0 
                    || double.TryParse(txt_Price.Text, out price) == false || price <= 0)
                {
                    MessageBox.Show("Invalid Inputs");
                }
                else
                {
                    if (radio_sell.Checked)
                        quantity = -1 * quantity;
                    if (call_put == "Call")
                        call_put_abrev = "_C";
                    else if (call_put == "Put")
                        call_put_abrev = "_P";
                    else
                        call_put_abrev = "_Null";

                    string strike_abbrev = "_" + strike.ToString();
                    DateTime date = DateTime.Now;
                    string instrument = underlying_ticker + call_put_abrev + strike_abbrev;

                    Trade new_trade = new Trade
                    {
                        Quantity = quantity,
                        TradePrice = price,
                        Timestamp = date,
                        InstrumentType = type,
                        Instrument = instrument
                    };

                    Model1Container2 model1Container = new Model1Container2();
                    model1Container.Trades.Add(new_trade);
                    model1Container.SaveChanges();
                    this.Close();
                }




 
                


                
            }
            
        }
    }
}
