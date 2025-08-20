using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExBasicQueuingCashier
{
    
    public partial class Form1 : Form
    {
        private CashierWindowQueueForm cashierform;
        private CashierClass cashier;//this access modifier to declare a class
        public Form1()
        {
            InitializeComponent();
            cashier = new CashierClass(); // initialize to call the cashierclass
            cashierform = new CashierWindowQueueForm();
            cashierform.Show();
        }
        private void bttnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);   
        }

        
    }
}

