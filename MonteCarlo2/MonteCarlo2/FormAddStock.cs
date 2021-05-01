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
    public partial class FormAddStock : Form
    {
        public FormAddStock()
        {
            InitializeComponent();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            string name = txt_StockName.Text.ToString();
            string ticker = txt_StockTicker.Text.ToString();
            string exchange = txt_Exchange.Text.ToString();

            Stocks new_stock = new Stocks
            {
                Name = name,
                Exchange = exchange,
                Ticker = ticker
            };

            //check if already exists
            Model1Container2 model1Container = new Model1Container2();
            model1Container.Stocks.Add(new_stock);
            model1Container.SaveChanges();
            this.Close(); 
        }
    }
}
