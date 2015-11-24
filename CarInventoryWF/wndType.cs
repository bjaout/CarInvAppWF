using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInventoryWF
{
    public partial class wndType : Form
    {
        public wndType()
        {
            InitializeComponent();
        }

        private void btnVoiture_Click(object sender, EventArgs e)
        {
            GlobalData.Choice = 0;
            this.Close();
        }

        private void btnMoto_Click(object sender, EventArgs e)
        {
            GlobalData.Choice = 1;
            this.Close();
        }
    }
}
