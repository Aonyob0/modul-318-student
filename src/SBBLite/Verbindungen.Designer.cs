namespace SBBLite
{
    partial class Verbindungen
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
            this.btnVerbindungenForms = new System.Windows.Forms.Button();
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
            this.dgvVerbindungSuchen = new System.Windows.Forms.DataGridView();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZeitAbfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZeitAnkunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GleisNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZeitGesamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.connectionPointBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungSuchen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerbindungenForms
            // 
            this.btnVerbindungenForms.Location = new System.Drawing.Point(193, 16);
            this.btnVerbindungenForms.Name = "btnVerbindungenForms";
            this.btnVerbindungenForms.Size = new System.Drawing.Size(170, 27);
            this.btnVerbindungenForms.TabIndex = 0;
            this.btnVerbindungenForms.Text = "Verbindungen";
            this.btnVerbindungenForms.UseVisualStyleBackColor = true;
            this.btnVerbindungenForms.Click += new System.EventHandler(this.btnVerbindungenFormsClick);
            // 
            // btnStationenForms
            // 
            this.btnStationenForms.Location = new System.Drawing.Point(389, 16);
            this.btnStationenForms.Name = "btnStationenForms";
            this.btnStationenForms.Size = new System.Drawing.Size(172, 27);
            this.btnStationenForms.TabIndex = 2;
            this.btnStationenForms.Text = "Stationen";
            this.btnStationenForms.UseVisualStyleBackColor = true;
            this.btnStationenForms.Click += new System.EventHandler(this.btnStationenFormsClick);
            // 
            // tbxVerbindungStart
            // 
            this.tbxVerbindungStart.Location = new System.Drawing.Point(193, 59);
            this.tbxVerbindungStart.Name = "tbxVerbindungStart";
            this.tbxVerbindungStart.PlaceholderText = "Start...";
            this.tbxVerbindungStart.Size = new System.Drawing.Size(170, 27);
            this.tbxVerbindungStart.TabIndex = 3;
            // 
            // tbxVerbindungZiel
            // 
            this.tbxVerbindungZiel.Location = new System.Drawing.Point(389, 59);
            this.tbxVerbindungZiel.Name = "tbxVerbindungZiel";
            this.tbxVerbindungZiel.PlaceholderText = "Ziel...";
            this.tbxVerbindungZiel.Size = new System.Drawing.Size(170, 27);
            this.tbxVerbindungZiel.TabIndex = 4;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(389, 101);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(170, 27);
            this.dtpDatum.TabIndex = 5;
            this.dtpDatum.Value = new System.DateTime(2022, 2, 8, 0, 0, 0, 0);
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(193, 101);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(170, 27);
            this.dtpTime.TabIndex = 6;
            this.dtpTime.Value = new System.DateTime(2022, 2, 8, 15, 58, 42, 0);
            // 
            // btnSuchenVerbindung
            // 
            this.btnSuchenVerbindung.Location = new System.Drawing.Point(316, 134);
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
            // dgvVerbindungSuchen
            // 
            this.dgvVerbindungSuchen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerbindungSuchen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationName,
            this.ZeitAbfahrt,
            this.ZeitAnkunft,
            this.GleisNummer,
            this.ZeitGesamt});
            this.dgvVerbindungSuchen.Location = new System.Drawing.Point(12, 200);
            this.dgvVerbindungSuchen.Name = "dgvVerbindungSuchen";
            this.dgvVerbindungSuchen.RowHeadersWidth = 51;
            this.dgvVerbindungSuchen.RowTemplate.Height = 29;
            this.dgvVerbindungSuchen.Size = new System.Drawing.Size(712, 188);
            this.dgvVerbindungSuchen.TabIndex = 8;
            // 
            // StationName
            // 
            this.StationName.HeaderText = "Station";
            this.StationName.MinimumWidth = 6;
            this.StationName.Name = "StationName";
            this.StationName.Width = 125;
            // 
            // ZeitAbfahrt
            // 
            this.ZeitAbfahrt.HeaderText = "Abfahrt";
            this.ZeitAbfahrt.MinimumWidth = 6;
            this.ZeitAbfahrt.Name = "ZeitAbfahrt";
            this.ZeitAbfahrt.Width = 125;
            // 
            // ZeitAnkunft
            // 
            this.ZeitAnkunft.HeaderText = "Ankunft";
            this.ZeitAnkunft.MinimumWidth = 6;
            this.ZeitAnkunft.Name = "ZeitAnkunft";
            this.ZeitAnkunft.Width = 125;
            // 
            // GleisNummer
            // 
            this.GleisNummer.HeaderText = "Gleis";
            this.GleisNummer.MinimumWidth = 6;
            this.GleisNummer.Name = "GleisNummer";
            this.GleisNummer.Width = 125;
            // 
            // ZeitGesamt
            // 
            this.ZeitGesamt.HeaderText = "Dauer";
            this.ZeitGesamt.MinimumWidth = 6;
            this.ZeitGesamt.Name = "ZeitGesamt";
            this.ZeitGesamt.Width = 125;
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 541);
            this.Controls.Add(this.dgvVerbindungSuchen);
            this.Controls.Add(this.btnSuchenVerbindung);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbxVerbindungZiel);
            this.Controls.Add(this.tbxVerbindungStart);
            this.Controls.Add(this.btnStationenForms);
            this.Controls.Add(this.btnVerbindungenForms);
            this.Name = "Verbindungen";
            this.Text = "Verbindungen";
            ((System.ComponentModel.ISupportInitialize)(this.connectionPointBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerbindungSuchen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVerbindungenForms;
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
        private DataGridView dgvVerbindungSuchen;
        private DataGridViewTextBoxColumn StationName;
        private DataGridViewTextBoxColumn ZeitAbfahrt;
        private DataGridViewTextBoxColumn ZeitAnkunft;
        private DataGridViewTextBoxColumn GleisNummer;
        private DataGridViewTextBoxColumn ZeitGesamt;
        private System.Windows.Forms.Timer timer1;
    }
}