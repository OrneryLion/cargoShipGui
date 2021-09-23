using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cargoShipGui
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

        private void btn_newShip_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            updateUI();

        }
        private void updateUI()
        {
            // set all of the controls to match the ship properties.
            progressBar1.Maximum = ship.Capacity;
            if (ship.getShipLoad() <= ship.Capacity)
                progressBar1.Value = ship.getShipLoad();

            lbl_shipLabel.Text = ship.ToString();

            // motorcycles
            label1.Text = ship.cycleCount.ToString();

            // cars
            label2.Text = ship.carCount.ToString();

            // trucks
            label5.Text = ship.truckCount.ToString();

            // trains
            label6.Text = ship.trainCarCount.ToString();

            if(ship.overUnder() == 0)
            {
                progressBar1.ForeColor = Color.Green;
            }
            if(ship.overUnder()!= 0)
            {
                progressBar1.ForeColor = Color.Yellow;
            }
            if(ship.overUnder() < 0)
            {
                progressBar1.ForeColor = Color.Red;
            }
        }

        private void trackBar_motorCyles_Scroll(object sender, EventArgs e)
        {
            ship.cycleCount = trackBar_motorCyles.Value;
            updateUI();
        }

        private void track_cars_Scroll(object sender, EventArgs e)
        {
            ship.carCount = track_cars.Value;
            updateUI();
        }

        private void track_trucks_Scroll(object sender, EventArgs e)
        {
            ship.truckCount = track_trucks.Value;
            updateUI();
        }

        private void track_trainCars_Scroll(object sender, EventArgs e)
        {
            ship.trainCarCount = track_trainCars.Value;
            updateUI();
        }
    }
}
