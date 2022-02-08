namespace SBBLite
{
    partial class Stationen
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
            this.btnStationenForms = new System.Windows.Forms.Button();
            this.btnVerbindungenForms = new System.Windows.Forms.Button();
            this.tbxStationEingabe = new System.Windows.Forms.TextBox();
            this.btnStationSuchen = new System.Windows.Forms.Button();
            this.dgvStationen = new System.Windows.Forms.DataGridView();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStationenForms
            // 
            this.btnStationenForms.Location = new System.Drawing.Point(374, 12);
            this.btnStationenForms.Name = "btnStationenForms";
            this.btnStationenForms.Size = new System.Drawing.Size(181, 27);
            this.btnStationenForms.TabIndex = 13;
            this.btnStationenForms.Text = "Stationen";
            this.btnStationenForms.UseVisualStyleBackColor = true;
            this.btnStationenForms.Click += new System.EventHandler(this.btnStationenFormsClick);
            // 
            // btnVerbindungenForms
            // 
            this.btnVerbindungenForms.Location = new System.Drawing.Point(187, 12);
            this.btnVerbindungenForms.Name = "btnVerbindungenForms";
            this.btnVerbindungenForms.Size = new System.Drawing.Size(181, 27);
            this.btnVerbindungenForms.TabIndex = 11;
            this.btnVerbindungenForms.Text = "Verbindungen";
            this.btnVerbindungenForms.UseVisualStyleBackColor = true;
            this.btnVerbindungenForms.Click += new System.EventHandler(this.btnVerbindungenFormsClick);
            // 
            // tbxStationEingabe
            // 
            this.tbxStationEingabe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxStationEingabe.Location = new System.Drawing.Point(187, 66);
            this.tbxStationEingabe.Name = "tbxStationEingabe";
            this.tbxStationEingabe.PlaceholderText = "Station...";
            this.tbxStationEingabe.Size = new System.Drawing.Size(181, 27);
            this.tbxStationEingabe.TabIndex = 14;
            // 
            // btnStationSuchen
            // 
            this.btnStationSuchen.Location = new System.Drawing.Point(412, 65);
            this.btnStationSuchen.Name = "btnStationSuchen";
            this.btnStationSuchen.Size = new System.Drawing.Size(143, 29);
            this.btnStationSuchen.TabIndex = 15;
            this.btnStationSuchen.Text = "Suchen";
            this.btnStationSuchen.UseVisualStyleBackColor = true;
            this.btnStationSuchen.Click += new System.EventHandler(this.btnStationSuchenClick);
            // 
            // dgvStationen
            // 
            this.dgvStationen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationName,
            this.Id});
            this.dgvStationen.Location = new System.Drawing.Point(187, 124);
            this.dgvStationen.MultiSelect = false;
            this.dgvStationen.Name = "dgvStationen";
            this.dgvStationen.ReadOnly = true;
            this.dgvStationen.RowHeadersWidth = 51;
            this.dgvStationen.RowTemplate.Height = 29;
            this.dgvStationen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStationen.Size = new System.Drawing.Size(368, 188);
            this.dgvStationen.TabIndex = 17;
            this.dgvStationen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStationen_CellContentClick);
            // 
            // StationName
            // 
            this.StationName.HeaderText = "Station";
            this.StationName.MinimumWidth = 6;
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            this.StationName.Width = 125;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Stationen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 541);
            this.Controls.Add(this.dgvStationen);
            this.Controls.Add(this.btnStationSuchen);
            this.Controls.Add(this.tbxStationEingabe);
            this.Controls.Add(this.btnStationenForms);
            this.Controls.Add(this.btnVerbindungenForms);
            this.Name = "Stationen";
            this.Text = "Stationen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStationenForms;
        private Button btnVerbindungenForms;
        private TextBox tbxStationEingabe;
        private Button btnStationSuchen;
        private DataGridView dgvStationen;
        private DataGridViewTextBoxColumn StationName;
        private DataGridViewTextBoxColumn Id;
    }
}