
namespace cargoShipGui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_newShip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_motorCycles = new System.Windows.Forms.Label();
            this.lbl_cars = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_trucks = new System.Windows.Forms.Label();
            this.lbl_trainCars = new System.Windows.Forms.Label();
            this.trackBar_motorCyles = new System.Windows.Forms.TrackBar();
            this.track_cars = new System.Windows.Forms.TrackBar();
            this.track_trucks = new System.Windows.Forms.TrackBar();
            this.track_trainCars = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_shipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_motorCyles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cargoShipGui.Properties.Resources.cargoship;
            this.pictureBox1.Location = new System.Drawing.Point(63, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_newShip
            // 
            this.btn_newShip.Location = new System.Drawing.Point(38, 597);
            this.btn_newShip.Name = "btn_newShip";
            this.btn_newShip.Size = new System.Drawing.Size(85, 37);
            this.btn_newShip.TabIndex = 1;
            this.btn_newShip.Text = "New Ship";
            this.btn_newShip.UseVisualStyleBackColor = true;
            this.btn_newShip.Click += new System.EventHandler(this.btn_newShip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // lbl_motorCycles
            // 
            this.lbl_motorCycles.AutoSize = true;
            this.lbl_motorCycles.Location = new System.Drawing.Point(113, 406);
            this.lbl_motorCycles.Name = "lbl_motorCycles";
            this.lbl_motorCycles.Size = new System.Drawing.Size(134, 16);
            this.lbl_motorCycles.TabIndex = 4;
            this.lbl_motorCycles.Text = "Motor Cycles (3 units)";
            // 
            // lbl_cars
            // 
            this.lbl_cars.AutoSize = true;
            this.lbl_cars.Location = new System.Drawing.Point(594, 406);
            this.lbl_cars.Name = "lbl_cars";
            this.lbl_cars.Size = new System.Drawing.Size(84, 16);
            this.lbl_cars.TabIndex = 5;
            this.lbl_cars.Text = "Cars (5 units)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // lbl_trucks
            // 
            this.lbl_trucks.AutoSize = true;
            this.lbl_trucks.Location = new System.Drawing.Point(123, 550);
            this.lbl_trucks.Name = "lbl_trucks";
            this.lbl_trucks.Size = new System.Drawing.Size(104, 16);
            this.lbl_trucks.TabIndex = 8;
            this.lbl_trucks.Text = "Trucks (11 units)";
            // 
            // lbl_trainCars
            // 
            this.lbl_trainCars.AutoSize = true;
            this.lbl_trainCars.Location = new System.Drawing.Point(553, 550);
            this.lbl_trainCars.Name = "lbl_trainCars";
            this.lbl_trainCars.Size = new System.Drawing.Size(125, 16);
            this.lbl_trainCars.TabIndex = 9;
            this.lbl_trainCars.Text = "Train Cars (17 units)";
            // 
            // trackBar_motorCyles
            // 
            this.trackBar_motorCyles.Location = new System.Drawing.Point(100, 347);
            this.trackBar_motorCyles.Name = "trackBar_motorCyles";
            this.trackBar_motorCyles.Size = new System.Drawing.Size(167, 45);
            this.trackBar_motorCyles.TabIndex = 10;
            this.trackBar_motorCyles.Scroll += new System.EventHandler(this.trackBar_motorCyles_Scroll);
            // 
            // track_cars
            // 
            this.track_cars.Location = new System.Drawing.Point(536, 347);
            this.track_cars.Name = "track_cars";
            this.track_cars.Size = new System.Drawing.Size(167, 45);
            this.track_cars.TabIndex = 11;
            this.track_cars.Scroll += new System.EventHandler(this.track_cars_Scroll);
            // 
            // track_trucks
            // 
            this.track_trucks.Location = new System.Drawing.Point(100, 493);
            this.track_trucks.Name = "track_trucks";
            this.track_trucks.Size = new System.Drawing.Size(167, 45);
            this.track_trucks.TabIndex = 12;
            this.track_trucks.Scroll += new System.EventHandler(this.track_trucks_Scroll);
            // 
            // track_trainCars
            // 
            this.track_trainCars.Location = new System.Drawing.Point(536, 493);
            this.track_trainCars.Name = "track_trainCars";
            this.track_trainCars.Size = new System.Drawing.Size(167, 45);
            this.track_trainCars.TabIndex = 13;
            this.track_trainCars.Scroll += new System.EventHandler(this.track_trainCars_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(207, 96);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(566, 101);
            this.progressBar1.TabIndex = 14;
            // 
            // lbl_shipLabel
            // 
            this.lbl_shipLabel.AutoSize = true;
            this.lbl_shipLabel.Location = new System.Drawing.Point(158, 247);
            this.lbl_shipLabel.Name = "lbl_shipLabel";
            this.lbl_shipLabel.Size = new System.Drawing.Size(45, 16);
            this.lbl_shipLabel.TabIndex = 15;
            this.lbl_shipLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 658);
            this.Controls.Add(this.lbl_shipLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.track_trainCars);
            this.Controls.Add(this.track_trucks);
            this.Controls.Add(this.track_cars);
            this.Controls.Add(this.trackBar_motorCyles);
            this.Controls.Add(this.lbl_trainCars);
            this.Controls.Add(this.lbl_trucks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_cars);
            this.Controls.Add(this.lbl_motorCycles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_newShip);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Cargo Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_motorCyles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_newShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_motorCycles;
        private System.Windows.Forms.Label lbl_cars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_trucks;
        private System.Windows.Forms.Label lbl_trainCars;
        private System.Windows.Forms.TrackBar trackBar_motorCyles;
        private System.Windows.Forms.TrackBar track_cars;
        private System.Windows.Forms.TrackBar track_trucks;
        private System.Windows.Forms.TrackBar track_trainCars;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_shipLabel;
    }
}

