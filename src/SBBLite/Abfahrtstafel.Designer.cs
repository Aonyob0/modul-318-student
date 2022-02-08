namespace SBBLite
{
    partial class Abfahrtstafel
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
            this.dgvAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.StationNach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.övNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbfahrtstafel
            // 
            this.dgvAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationNach,
            this.övNummer,
            this.Abfahrt});
            this.dgvAbfahrtstafel.Location = new System.Drawing.Point(12, 206);
            this.dgvAbfahrtstafel.Name = "dgvAbfahrtstafel";
            this.dgvAbfahrtstafel.RowHeadersWidth = 51;
            this.dgvAbfahrtstafel.RowTemplate.Height = 29;
            this.dgvAbfahrtstafel.Size = new System.Drawing.Size(712, 271);
            this.dgvAbfahrtstafel.TabIndex = 0;
            // 
            // StationNach
            // 
            this.StationNach.HeaderText = "Nach";
            this.StationNach.MinimumWidth = 6;
            this.StationNach.Name = "StationNach";
            this.StationNach.Width = 125;
            // 
            // övNummer
            // 
            this.övNummer.HeaderText = "Nummer";
            this.övNummer.MinimumWidth = 6;
            this.övNummer.Name = "övNummer";
            this.övNummer.Width = 125;
            // 
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.MinimumWidth = 6;
            this.Abfahrt.Name = "Abfahrt";
            this.Abfahrt.Width = 125;
            // 
            // Abfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 541);
            this.Controls.Add(this.dgvAbfahrtstafel);
            this.Name = "Abfahrtstafel";
            this.Text = "Abfahrtstafel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvAbfahrtstafel;
        private DataGridViewTextBoxColumn StationNach;
        private DataGridViewTextBoxColumn övNummer;
        private DataGridViewTextBoxColumn Abfahrt;
    }
}