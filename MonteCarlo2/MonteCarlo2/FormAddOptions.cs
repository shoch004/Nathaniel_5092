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
    public partial class FormAddOptions : Form
    {
        public FormAddOptions()
        {
            InitializeComponent();
        }

        private void FormAddOptions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTradeDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.dbTradeDataSet.Stocks);

        }

        private void btn_AddOption_Click(object sender, EventArgs e)
        {
            double strike;
            double tenor;
            double rebate = -1;
            double barrier = -1;
            string type;
            string call_put;
            string underlying;

            if (double.TryParse(txt_Strike.Text, out strike) == false || strike <= 0 
                || double.TryParse(txt_Tenor.Text, out tenor) == false || tenor <= 0)
            {
                MessageBox.Show("Invalid Inputs");
            }
            else if (drop_OptionType.Text == "Digital" && 
                (double.TryParse(txt_Rebate.Text, out rebate) == false || rebate <= 0))
            {
                MessageBox.Show("Invalid Inputs");
            }
            else if (drop_OptionType.Text == "Barrier" && 
                (double.TryParse(txt_Barrier.Text, out barrier) == false || barrier <= 0))
            {
                MessageBox.Show("Invalid Inputs");
            }
            else
            {
                type = drop_OptionType.Text;
                if (radio_call.Checked)
                    call_put = "Call";
                else
                    call_put = "Put";
                underlying = drop_Stock.SelectedValue.ToString();
                Options new_option;
                if (drop_OptionType.Text == "Barrier")
                {
                    //assign the type of barrier option
                    string barrier_type;
                    if (radioBarrierDI.Checked)
                        barrier_type = "DI";
                    else if (radioBarrierDO.Checked)
                        barrier_type = "DO";
                    else if (radioBarrierUI.Checked)
                        barrier_type = "UI";
                    else
                        barrier_type = "UO";

                    new_option = new Options
                    {
                        Type = type + barrier_type,
                        CallPut = call_put,
                        Underlying = underlying,
                        Tenor = tenor,
                        Barrier = barrier,
                        Strike = strike

                    };
                }
                else if (drop_OptionType.Text == "Digital")
                {
                    new_option = new Options
                    {
                        Type = type,
                        CallPut = call_put,
                        Underlying = underlying,
                        Tenor = tenor,
                        Rebate = rebate,
                        Strike = strike
                    };
                }
                else if (drop_OptionType.Text == "Range")
                {
                    new_option = new Options
                    {
                        Type = type,
                        Underlying = underlying,
                        Tenor = tenor,
                        Strike = strike
                    };
                }
                else
                {
                    new_option = new Options
                    {
                        Type = type,
                        CallPut = call_put,
                        Underlying = underlying,
                        Tenor = tenor,
                        Strike = strike
                    };
                }
                Model1Container2 model1Container = new Model1Container2();
                model1Container.Options.Add(new_option);
                model1Container.SaveChanges();
                this.Close();
            }
        }
    }
}
