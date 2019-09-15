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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.materialContextMenuStrip2 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.materialContextMenuStrip3 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.mbutton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbutton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbutton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbutton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbutton5 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.openTableToolStripMenuItem,
            this.queriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 368);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
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
            this.groupBox1.Controls.Add(this.mbutton3);
            this.groupBox1.Controls.Add(this.mbutton4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(557, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 230);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by...";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 2;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // materialContextMenuStrip2
            // 
            this.materialContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip2.Depth = 0;
            this.materialContextMenuStrip2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip2.Name = "materialContextMenuStrip2";
            this.materialContextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // materialContextMenuStrip3
            // 
            this.materialContextMenuStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip3.Depth = 0;
            this.materialContextMenuStrip3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip3.Name = "materialContextMenuStrip3";
            this.materialContextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // mbutton1
            // 
            this.mbutton1.AutoSize = true;
            this.mbutton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbutton1.Depth = 0;
            this.mbutton1.Location = new System.Drawing.Point(557, 320);
            this.mbutton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbutton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbutton1.Name = "mbutton1";
            this.mbutton1.Primary = false;
            this.mbutton1.Size = new System.Drawing.Size(39, 36);
            this.mbutton1.TabIndex = 6;
            this.mbutton1.Text = "add";
            this.mbutton1.UseVisualStyleBackColor = true;
            this.mbutton1.Click += new System.EventHandler(this.mbutton1_Click);
            // 
            // mbutton4
            // 
            this.mbutton4.Depth = 0;
            this.mbutton4.Location = new System.Drawing.Point(6, 133);
            this.mbutton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbutton4.Name = "mbutton4";
            this.mbutton4.Primary = true;
            this.mbutton4.Size = new System.Drawing.Size(207, 36);
            this.mbutton4.TabIndex = 7;
            this.mbutton4.Text = "apply";
            this.mbutton4.UseVisualStyleBackColor = true;
            this.mbutton4.Click += new System.EventHandler(this.mbutton4_Click);
            // 
            // mbutton3
            // 
            this.mbutton3.Depth = 0;
            this.mbutton3.Location = new System.Drawing.Point(6, 187);
            this.mbutton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbutton3.Name = "mbutton3";
            this.mbutton3.Primary = true;
            this.mbutton3.Size = new System.Drawing.Size(207, 37);
            this.mbutton3.TabIndex = 8;
            this.mbutton3.Text = "Restore";
            this.mbutton3.UseVisualStyleBackColor = true;
            this.mbutton3.Click += new System.EventHandler(this.mbutton3_Click);
            // 
            // mbutton2
            // 
            this.mbutton2.AutoSize = true;
            this.mbutton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbutton2.Depth = 0;
            this.mbutton2.Location = new System.Drawing.Point(629, 320);
            this.mbutton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbutton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbutton2.Name = "mbutton2";
            this.mbutton2.Primary = false;
            this.mbutton2.Size = new System.Drawing.Size(66, 36);
            this.mbutton2.TabIndex = 7;
            this.mbutton2.Text = "remove";
            this.mbutton2.UseVisualStyleBackColor = true;
            this.mbutton2.Click += new System.EventHandler(this.mbutton2_Click);
            // 
            // mbutton5
            // 
            this.mbutton5.AutoSize = true;
            this.mbutton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbutton5.Depth = 0;
            this.mbutton5.Location = new System.Drawing.Point(730, 320);
            this.mbutton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbutton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbutton5.Name = "mbutton5";
            this.mbutton5.Primary = false;
            this.mbutton5.Size = new System.Drawing.Size(46, 36);
            this.mbutton5.TabIndex = 8;
            this.mbutton5.Text = "save";
            this.mbutton5.UseVisualStyleBackColor = true;
            this.mbutton5.Click += new System.EventHandler(this.mbutton5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 392);
            this.Controls.Add(this.mbutton5);
            this.Controls.Add(this.mbutton2);
            this.Controls.Add(this.mbutton1);
            this.Controls.Add(this.groupBox1);
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
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip2;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip3;
        private MaterialSkin.Controls.MaterialRaisedButton mbutton4;
        private MaterialSkin.Controls.MaterialFlatButton mbutton1;
        private MaterialSkin.Controls.MaterialRaisedButton mbutton3;
        private MaterialSkin.Controls.MaterialFlatButton mbutton2;
        private MaterialSkin.Controls.MaterialFlatButton mbutton5;
    }
}

