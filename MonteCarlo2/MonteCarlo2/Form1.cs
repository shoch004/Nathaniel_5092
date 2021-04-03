using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarlo2
{
    public partial class Form1 : Form
    {
        public delegate void IncrementProgress();
        public IncrementProgress myDelegate;

        public Form1()
        {
            InitializeComponent();
            myDelegate = new IncrementProgress(IncrementProgressMethod);

        }

       
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
