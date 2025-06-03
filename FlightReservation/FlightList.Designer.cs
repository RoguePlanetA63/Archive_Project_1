namespace FlightReservation
{
    partial class FlightList
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
            this.FlightListTable = new System.Windows.Forms.DataGridView();
            this.lblDateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FlightListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightListTable
            // 
            this.FlightListTable.AllowUserToAddRows = false;
            this.FlightListTable.AllowUserToDeleteRows = false;
            this.FlightListTable.AllowUserToOrderColumns = true;
            this.FlightListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightListTable.Location = new System.Drawing.Point(0, 35);
            this.FlightListTable.Name = "FlightListTable";
            this.FlightListTable.ReadOnly = true;
            this.FlightListTable.Size = new System.Drawing.Size(242, 439);
            this.FlightListTable.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Location = new System.Drawing.Point(134, 13);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(108, 19);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "DateTime";
            // 
            // FlightList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 475);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.FlightListTable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlightList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "List";
            this.Load += new System.EventHandler(this.FlightList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightListTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDateTime;
        public System.Windows.Forms.DataGridView FlightListTable;
    }
}