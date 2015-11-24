using System;
using System.IO;
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
    public partial class wndMain : Form
    {

        private List<Vehicle> inventory = new List<Vehicle>();
        private string file;
        

        public wndMain()
        {
            InitializeComponent();
            string dir = @"c:\temp";
            file = Path.Combine(dir, "vehicles.bin");
            ReadData();
            this.FormClosed += new FormClosedEventHandler(wndMain_FormClosed);
            this.rtxtAffichage.AppendText("Bienvenu dans le programme graphique de gestion de véhicules");
            this.rtxtAffichage.AppendText("\nLes boutons sur le coté droit de l'écran vous permettront de choisir les différentes fonctionnalités");
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            this.rtxtAffichage.Clear();
            this.rtxtAffichage.AppendText("Voici la liste des véhicules :");
            this.rtxtAffichage.AppendText(Environment.NewLine);
            foreach (Vehicle elem in inventory)
            {
                this.rtxtAffichage.AppendText(elem.ToString());
                this.rtxtAffichage.AppendText(Environment.NewLine);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            this.Hide();
            wndType newWindow = new wndType();
            newWindow.Show();
            newWindow.FormClosed += wndType_FormClosed;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.Hide();
            wndDelete newWindow = new wndDelete(inventory);
            newWindow.Show();
            newWindow.FormClosed += wnd_FormClosed;
        }

        private void btnNettoyer_Click(object sender, EventArgs e)
        {
            inventory.Clear();
            this.rtxtAffichage.Clear();
            this.rtxtAffichage.AppendText("Liste vidée");
        }

        private void wndType_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch(GlobalData.Choice)
            {
                case 0:
                    wndCar newWindow = new wndCar();
                    newWindow.Show();
                    newWindow.FormClosed += wnd_AddFormClosed;
                    break;
                case 1:
                    break;
                default:
                    break;
            }
        }

        private void wnd_AddFormClosed(object sender, FormClosedEventArgs e)
        {
            inventory.Add(GlobalData.Vehicule);
            this.Show();
        }

        private void wnd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void wndMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (Stream stream = File.Open(file, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bformatter.Serialize(stream, inventory);
            }
        }

        /// <summary>
        /// Read data from binary file
        /// </summary>
        private void ReadData()
        {
            try
            {
                // Read data saved from previous execution
                using (Stream stream = File.Open(file, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    inventory = (List<Vehicle>)bformatter.Deserialize(stream);
                }
            }
            // If file is not found then create it and close it afterwards or there will be an error when saving
            catch (FileNotFoundException e)
            {
                Stream stream = File.Open(file, FileMode.Create);
                stream.Close();
            }
            // If file contains no data or bad data then just consider that inventory is empty
            catch (System.Runtime.Serialization.SerializationException e)
            {
                inventory.Clear();
            }
        }
    }
}
