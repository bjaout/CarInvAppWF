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
    public partial class wndCar : Form
    {
        public wndCar()
        {
            InitializeComponent();
            this.FormClosing += WndCar_FormClosing;
        }

        private void WndCar_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalData.Vehicule = new Car(this.txtMarque.Text, this.txtModele.Text, 5, (int)this.numPorte.Value, (int)this.numPuissance.Value, (Car.TrunkType)this.lbCoffre.SelectedIndex);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
