namespace SBBLite
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnSuchenForms = new System.Windows.Forms.Button();
            this.btnAbfahrtstafelForms = new System.Windows.Forms.Button();
            this.btnStationenForms = new System.Windows.Forms.Button();
            this.tbxVerbindungStart = new System.Windows.Forms.TextBox();
            this.tbxVerbindungZiel = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSuchenVerbindung = new System.Windows.Forms.Button();
            this.connectionPointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.connectionPointBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuchenForms
            // 
            this.btnSuchenForms.Location = new System.Drawing.Point(15, 16);
            this.btnSuchenForms.Name = "btnSuchenForms";
            this.btnSuchenForms.Size = new System.Drawing.Size(123, 27);
            this.btnSuchenForms.TabIndex = 0;
            this.btnSuchenForms.Text = "Suchen";
            this.btnSuchenForms.UseVisualStyleBackColor = true;
            this.btnSuchenForms.Click += new System.EventHandler(this.btnSuchenFormsClick);
            // 
            // btnAbfahrtstafelForms
            // 
            this.btnAbfahrtstafelForms.Location = new System.Drawing.Point(136, 16);
            this.btnAbfahrtstafelForms.Name = "btnAbfahrtstafelForms";
            this.btnAbfahrtstafelForms.Size = new System.Drawing.Size(123, 27);
            this.btnAbfahrtstafelForms.TabIndex = 1;
            this.btnAbfahrtstafelForms.Text = "Abfahrtstafel";
            this.btnAbfahrtstafelForms.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafelForms.Click += new System.EventHandler(this.btnAbfahrtstafelFormsClick);
            // 
            // btnStationenForms
            // 
            this.btnStationenForms.Location = new System.Drawing.Point(256, 16);
            this.btnStationenForms.Name = "btnStationenForms";
            this.btnStationenForms.Size = new System.Drawing.Size(123, 27);
            this.btnStationenForms.TabIndex = 2;
            this.btnStationenForms.Text = "Stationen";
            this.btnStationenForms.UseVisualStyleBackColor = true;
            this.btnStationenForms.Click += new System.EventHandler(this.btnStationenFormsClick);
            // 
            // tbxVerbindungStart
            // 
            this.tbxVerbindungStart.Location = new System.Drawing.Point(15, 59);
            this.tbxVerbindungStart.Name = "tbxVerbindungStart";
            this.tbxVerbindungStart.PlaceholderText = "Start...";
            this.tbxVerbindungStart.Size = new System.Drawing.Size(170, 27);
            this.tbxVerbindungStart.TabIndex = 3;
            // 
            // tbxVerbindungZiel
            // 
            this.tbxVerbindungZiel.Location = new System.Drawing.Point(209, 59);
            this.tbxVerbindungZiel.Name = "tbxVerbindungZiel";
            this.tbxVerbindungZiel.PlaceholderText = "Ziel...";
            this.tbxVerbindungZiel.Size = new System.Drawing.Size(170, 27);
            this.tbxVerbindungZiel.TabIndex = 4;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(209, 101);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(170, 27);
            this.dtpDatum.TabIndex = 5;
            this.dtpDatum.Value = new System.DateTime(2022, 2, 3, 0, 0, 0, 0);
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(15, 101);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(170, 27);
            this.dtpTime.TabIndex = 6;
            this.dtpTime.Value = new System.DateTime(2022, 2, 3, 14, 1, 0, 0);
            // 
            // btnSuchenVerbindung
            // 
            this.btnSuchenVerbindung.Location = new System.Drawing.Point(136, 143);
            this.btnSuchenVerbindung.Name = "btnSuchenVerbindung";
            this.btnSuchenVerbindung.Size = new System.Drawing.Size(123, 27);
            this.btnSuchenVerbindung.TabIndex = 7;
            this.btnSuchenVerbindung.Text = "Suchen";
            this.btnSuchenVerbindung.UseVisualStyleBackColor = true;
            this.btnSuchenVerbindung.Click += new System.EventHandler(this.btnSuchenVerbindungClick);
            // 
            // connectionPointBindingSource
            // 
            this.connectionPointBindingSource.DataSource = typeof(SwissTransport.Models.ConnectionPoint);
            // 
            // connectionBindingSource
            // 
            this.connectionBindingSource.DataSource = typeof(SwissTransport.Models.Connection);
            // 
            // connectionsBindingSource
            // 
            this.connectionsBindingSource.DataSource = typeof(SwissTransport.Models.Connections);
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataSource = typeof(SwissTransport.Models.Station);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 541);
            this.Controls.Add(this.btnSuchenVerbindung);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbxVerbindungZiel);
            this.Controls.Add(this.tbxVerbindungStart);
            this.Controls.Add(this.btnStationenForms);
            this.Controls.Add(this.btnAbfahrtstafelForms);
            this.Controls.Add(this.btnSuchenForms);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.connectionPointBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSuchenForms;
        private Button btnAbfahrtstafelForms;
        private Button btnStationenForms;
        private TextBox tbxVerbindungStart;
        private TextBox tbxVerbindungZiel;
        private DateTimePicker dtpDatum;
        private DateTimePicker dtpTime;
        private Button btnSuchenVerbindung;
        private BindingSource connectionPointBindingSource;
        private BindingSource connectionBindingSource;
        private BindingSource connectionsBindingSource;
        private BindingSource stationBindingSource;
    }
}