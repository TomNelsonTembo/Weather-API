namespace WeatherAPI_Project
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.TBcity = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.labelcondition = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Sunrise_details = new System.Windows.Forms.Label();
            this.sunset_details = new System.Windows.Forms.Label();
            this.pressure_details = new System.Windows.Forms.Label();
            this.windspeed_details = new System.Windows.Forms.Label();
            this.pressureLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.weather_ico = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.temp_lbl = new System.Windows.Forms.Label();
            this.city_name = new System.Windows.Forms.Label();
            this.hstry_dgv = new System.Windows.Forms.DataGridView();
            this.reset_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weather_ico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hstry_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TBcity
            // 
            this.TBcity.Location = new System.Drawing.Point(88, 28);
            this.TBcity.Name = "TBcity";
            this.TBcity.Size = new System.Drawing.Size(253, 27);
            this.TBcity.TabIndex = 1;
            this.TBcity.Text = "Enter City/Country...";
            this.TBcity.TextChanged += new System.EventHandler(this.TBcity_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_search.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_search.Location = new System.Drawing.Point(359, 22);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 38);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // labelcondition
            // 
            this.labelcondition.AutoSize = true;
            this.labelcondition.BackColor = System.Drawing.Color.Transparent;
            this.labelcondition.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelcondition.Location = new System.Drawing.Point(29, 101);
            this.labelcondition.Name = "labelcondition";
            this.labelcondition.Size = new System.Drawing.Size(102, 28);
            this.labelcondition.TabIndex = 3;
            this.labelcondition.Text = "Condition";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelDetails.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDetails.Location = new System.Drawing.Point(29, 141);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(75, 28);
            this.labelDetails.TabIndex = 4;
            this.labelDetails.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(29, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sunrise:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(29, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sunset:";
            // 
            // Sunrise_details
            // 
            this.Sunrise_details.AutoSize = true;
            this.Sunrise_details.BackColor = System.Drawing.Color.Transparent;
            this.Sunrise_details.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sunrise_details.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sunrise_details.Location = new System.Drawing.Point(130, 220);
            this.Sunrise_details.Name = "Sunrise_details";
            this.Sunrise_details.Size = new System.Drawing.Size(48, 28);
            this.Sunrise_details.TabIndex = 7;
            this.Sunrise_details.Text = "N/A";
            // 
            // sunset_details
            // 
            this.sunset_details.AutoSize = true;
            this.sunset_details.BackColor = System.Drawing.Color.Transparent;
            this.sunset_details.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sunset_details.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sunset_details.Location = new System.Drawing.Point(130, 260);
            this.sunset_details.Name = "sunset_details";
            this.sunset_details.Size = new System.Drawing.Size(48, 28);
            this.sunset_details.TabIndex = 8;
            this.sunset_details.Text = "N/A";
            // 
            // pressure_details
            // 
            this.pressure_details.AutoSize = true;
            this.pressure_details.BackColor = System.Drawing.Color.Transparent;
            this.pressure_details.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pressure_details.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pressure_details.Location = new System.Drawing.Point(359, 141);
            this.pressure_details.Name = "pressure_details";
            this.pressure_details.Size = new System.Drawing.Size(48, 28);
            this.pressure_details.TabIndex = 12;
            this.pressure_details.Text = "N/A";
            // 
            // windspeed_details
            // 
            this.windspeed_details.AutoSize = true;
            this.windspeed_details.BackColor = System.Drawing.Color.Transparent;
            this.windspeed_details.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.windspeed_details.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.windspeed_details.Location = new System.Drawing.Point(378, 101);
            this.windspeed_details.Name = "windspeed_details";
            this.windspeed_details.Size = new System.Drawing.Size(48, 28);
            this.windspeed_details.TabIndex = 11;
            this.windspeed_details.Text = "N/A";
            // 
            // pressureLbl
            // 
            this.pressureLbl.AutoSize = true;
            this.pressureLbl.BackColor = System.Drawing.Color.Transparent;
            this.pressureLbl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pressureLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pressureLbl.Location = new System.Drawing.Point(243, 141);
            this.pressureLbl.Name = "pressureLbl";
            this.pressureLbl.Size = new System.Drawing.Size(98, 28);
            this.pressureLbl.TabIndex = 10;
            this.pressureLbl.Text = "Pressure:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(243, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 28);
            this.label9.TabIndex = 9;
            this.label9.Text = "Wind Speed:";
            // 
            // weather_ico
            // 
            this.weather_ico.BackColor = System.Drawing.Color.Transparent;
            this.weather_ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.weather_ico.Location = new System.Drawing.Point(359, 303);
            this.weather_ico.Name = "weather_ico";
            this.weather_ico.Size = new System.Drawing.Size(172, 135);
            this.weather_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weather_ico.TabIndex = 13;
            this.weather_ico.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // temp_lbl
            // 
            this.temp_lbl.AutoSize = true;
            this.temp_lbl.BackColor = System.Drawing.Color.Transparent;
            this.temp_lbl.Font = new System.Drawing.Font("Calibri", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.temp_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.temp_lbl.Location = new System.Drawing.Point(362, 180);
            this.temp_lbl.Name = "temp_lbl";
            this.temp_lbl.Size = new System.Drawing.Size(139, 122);
            this.temp_lbl.TabIndex = 14;
            this.temp_lbl.Text = "°C";
            this.temp_lbl.Click += new System.EventHandler(this.label2_Click);
            this.temp_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.temp_lbl_MouseMove);
            // 
            // city_name
            // 
            this.city_name.AutoSize = true;
            this.city_name.BackColor = System.Drawing.Color.Transparent;
            this.city_name.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.city_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.city_name.Location = new System.Drawing.Point(12, 387);
            this.city_name.Name = "city_name";
            this.city_name.Size = new System.Drawing.Size(56, 53);
            this.city_name.TabIndex = 15;
            this.city_name.Text = "...";
            this.city_name.Click += new System.EventHandler(this.city_name_Click);
            // 
            // hstry_dgv
            // 
            this.hstry_dgv.AllowUserToAddRows = false;
            this.hstry_dgv.AllowUserToDeleteRows = false;
            this.hstry_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.hstry_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hstry_dgv.Location = new System.Drawing.Point(622, 12);
            this.hstry_dgv.Name = "hstry_dgv";
            this.hstry_dgv.ReadOnly = true;
            this.hstry_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.hstry_dgv.RowTemplate.Height = 29;
            this.hstry_dgv.ShowEditingIcon = false;
            this.hstry_dgv.Size = new System.Drawing.Size(503, 426);
            this.hstry_dgv.TabIndex = 16;
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Transparent;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reset_btn.ForeColor = System.Drawing.Color.Red;
            this.reset_btn.Location = new System.Drawing.Point(542, 400);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(74, 38);
            this.reset_btn.TabIndex = 17;
            this.reset_btn.Text = "RESET";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherAPI_Project.Properties.Resources.pexels_eberhard_grossgasteiger_1292115_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1137, 450);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.hstry_dgv);
            this.Controls.Add(this.city_name);
            this.Controls.Add(this.temp_lbl);
            this.Controls.Add(this.weather_ico);
            this.Controls.Add(this.pressure_details);
            this.Controls.Add(this.windspeed_details);
            this.Controls.Add(this.pressureLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sunset_details);
            this.Controls.Add(this.Sunrise_details);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelcondition);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.TBcity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "WeathoMeter";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weather_ico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hstry_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox TBcity;
        private Button btn_search;
        private Label labelcondition;
        private Label labelDetails;
        private Label label4;
        private Label label5;
        private Label Sunrise_details;
        private Label sunset_details;
        private Label pressure_details;
        private Label windspeed_details;
        private Label pressureLbl;
        private Label label9;
        private PictureBox weather_ico;
        private Label label1;
        private Label temp_lbl;
        private Label city_name;
        private DataGridView hstry_dgv;
        private Button reset_btn;
    }
}