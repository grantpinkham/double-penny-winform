using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoublePennies
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int numOfPennies = 1;
            int sum = 1;
            int numOfDays = Convert.ToInt32(txtNumOfDays.Value);
            for (int days = 2; days <= numOfDays; days++)
            {
                numOfPennies *= 2;
                sum += numOfPennies;
            }
            txtTotal.Text = sum.ToString();
        }
    }
}
