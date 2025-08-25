using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExBasicQueuingCashier
{
    public partial class frmCustomerView : Form
    {
        public frmCustomerView()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000); // timer for update the label
            timer.Tick += new EventHandler(Update);
            timer.Start();
        }

        // this is for update automatically the number in queue when cashiers call the next in line
        public void Update(object  sender, EventArgs e)
        {
            Queue<string> cashierQueue = CashierClass.CashierQueue;
            lblServingQueue.Text = cashierQueue.Count > 0 ? cashierQueue.Peek() : " "; // this is to show the first number using the peek
        }

      
    }
}
