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
    public partial class FormAddRate : Form
    {
        public FormAddRate()
        {
            InitializeComponent();
        }

        private void btn_AddRate_Click(object sender, EventArgs e)
        {
            double tenor;
            double rate;
            if (double.TryParse(txt_Tenor.Text, out tenor) == false || tenor <= 0
                || double.TryParse(txt_Rate.Text, out rate) == false || rate <=0)
                MessageBox.Show("Invalid Inputs");
            else
            {
                TBill new_Tbill = new TBill
                {
                    Tenor = tenor,
                    Rate = rate
                };

                Model1Container2 model1Container = new Model1Container2();
                model1Container.TBills.Add(new_Tbill);
                model1Container.SaveChanges();
            
            }
            this.Close();
        }
    }
}
