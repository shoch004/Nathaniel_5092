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
            //calculate total P/L ,greeks and put them in a dictionary
            //collection / List of objects must be passed to a method to calculate thise
            //values. Then the Rows.Add() adds value by value example .Add(List[0], List[1], List[2] ...)
            //then implement delete, clear, calculate only highlighted values etc...

            //need Stock_ID search
            dataTotals.Rows.Add();




        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tradeToolDataSet.Trades' table. You can move, or remove it, as needed.
            this.tradesTableAdapter.Fill(this.tradeToolDataSet.Trades);

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
    }
}
