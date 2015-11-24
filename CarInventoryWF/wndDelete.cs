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
    public partial class wndDelete : Form
    {
        private List<Vehicle> inventaire;

        public wndDelete()
        {
            InitializeComponent();
        }

        public wndDelete(object inventaireComplet)
        {
            InitializeComponent();
            inventaire = (List<Vehicle>) inventaireComplet;
            foreach (Vehicle item in inventaire)
            {
                lbListe.Items.Add(item);
            }  
        }


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            inventaire.RemoveAt(lbListe.SelectedIndex);
            lbListe.Items.RemoveAt(lbListe.SelectedIndex);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
