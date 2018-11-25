namespace KursovayaBD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airfractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortPilotsBySurnameAndCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortPassengersByClassAndPlaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateRevenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getInformationAboutPassengersDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remove ticket";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.openTableToolStripMenuItem,
            this.queriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // openTableToolStripMenuItem
            // 
            this.openTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightsToolStripMenuItem,
            this.pilotsToolStripMenuItem,
            this.airfractsToolStripMenuItem,
            this.directionsToolStripMenuItem});
            this.openTableToolStripMenuItem.Name = "openTableToolStripMenuItem";
            this.openTableToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.openTableToolStripMenuItem.Text = "Open table";
            // 
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.flightsToolStripMenuItem.Text = "Flights";
            this.flightsToolStripMenuItem.Click += new System.EventHandler(this.flightsToolStripMenuItem_Click);
            // 
            // pilotsToolStripMenuItem
            // 
            this.pilotsToolStripMenuItem.Name = "pilotsToolStripMenuItem";
            this.pilotsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pilotsToolStripMenuItem.Text = "Pilots";
            this.pilotsToolStripMenuItem.Click += new System.EventHandler(this.pilotsToolStripMenuItem_Click);
            // 
            // airfractsToolStripMenuItem
            // 
            this.airfractsToolStripMenuItem.Name = "airfractsToolStripMenuItem";
            this.airfractsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.airfractsToolStripMenuItem.Text = "Aircrafts";
            this.airfractsToolStripMenuItem.Click += new System.EventHandler(this.airfractsToolStripMenuItem_Click);
            // 
            // directionsToolStripMenuItem
            // 
            this.directionsToolStripMenuItem.Name = "directionsToolStripMenuItem";
            this.directionsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.directionsToolStripMenuItem.Text = "Directions";
            this.directionsToolStripMenuItem.Click += new System.EventHandler(this.directionsToolStripMenuItem_Click);
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortPilotsBySurnameAndCategoryToolStripMenuItem,
            this.sortPassengersByClassAndPlaceToolStripMenuItem,
            this.discountInformationToolStripMenuItem,
            this.calculateRevenueToolStripMenuItem,
            this.getInformationAboutPassengersDestinationToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // sortPilotsBySurnameAndCategoryToolStripMenuItem
            // 
            this.sortPilotsBySurnameAndCategoryToolStripMenuItem.Name = "sortPilotsBySurnameAndCategoryToolStripMenuItem";
            this.sortPilotsBySurnameAndCategoryToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.sortPilotsBySurnameAndCategoryToolStripMenuItem.Text = "Sort pilots by surname and category";
            this.sortPilotsBySurnameAndCategoryToolStripMenuItem.Click += new System.EventHandler(this.sortPilotsBySurnameAndCategoryToolStripMenuItem_Click);
            // 
            // sortPassengersByClassAndPlaceToolStripMenuItem
            // 
            this.sortPassengersByClassAndPlaceToolStripMenuItem.Name = "sortPassengersByClassAndPlaceToolStripMenuItem";
            this.sortPassengersByClassAndPlaceToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.sortPassengersByClassAndPlaceToolStripMenuItem.Text = "Sort passengers by class and place";
            this.sortPassengersByClassAndPlaceToolStripMenuItem.Click += new System.EventHandler(this.sortPassengersByClassAndPlaceToolStripMenuItem_Click);
            // 
            // discountInformationToolStripMenuItem
            // 
            this.discountInformationToolStripMenuItem.Name = "discountInformationToolStripMenuItem";
            this.discountInformationToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.discountInformationToolStripMenuItem.Text = "Discount information";
            this.discountInformationToolStripMenuItem.Click += new System.EventHandler(this.discountInformationToolStripMenuItem_Click);
            // 
            // calculateRevenueToolStripMenuItem
            // 
            this.calculateRevenueToolStripMenuItem.Name = "calculateRevenueToolStripMenuItem";
            this.calculateRevenueToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.calculateRevenueToolStripMenuItem.Text = "Calculate revenue";
            this.calculateRevenueToolStripMenuItem.Click += new System.EventHandler(this.calculateRevenueToolStripMenuItem_Click);
            // 
            // getInformationAboutPassengersDestinationToolStripMenuItem
            // 
            this.getInformationAboutPassengersDestinationToolStripMenuItem.Name = "getInformationAboutPassengersDestinationToolStripMenuItem";
            this.getInformationAboutPassengersDestinationToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.getInformationAboutPassengersDestinationToolStripMenuItem.Text = "Get information about passengers\' destination";
            this.getInformationAboutPassengersDestinationToolStripMenuItem.Click += new System.EventHandler(this.getInformationAboutPassengersDestinationToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(457, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by...";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Restore";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ticket_class",
            "Passenger_surname",
            "Ticket_id"});
            this.comboBox1.Location = new System.Drawing.Point(6, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Apply";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(590, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 312);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airfractsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortPilotsBySurnameAndCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortPassengersByClassAndPlaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discountInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateRevenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getInformationAboutPassengersDestinationToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}

