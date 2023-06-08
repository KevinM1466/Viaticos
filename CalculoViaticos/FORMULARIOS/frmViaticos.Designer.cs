namespace CalculoViaticos.FORMULARIOS
{
    partial class frmViaticos
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
            this.dgViaticos = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgViaticos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViaticos
            // 
            this.dgViaticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViaticos.Location = new System.Drawing.Point(15, 41);
            this.dgViaticos.Name = "dgViaticos";
            this.dgViaticos.ReadOnly = true;
            this.dgViaticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViaticos.Size = new System.Drawing.Size(972, 463);
            this.dgViaticos.TabIndex = 1;
            this.dgViaticos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViaticos_CellDoubleClick);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(15, 523);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(208, 47);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Hacer Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // frmViaticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 618);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dgViaticos);
            this.Name = "frmViaticos";
            this.Text = "frmViaticos";
            this.Load += new System.EventHandler(this.frmViaticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViaticos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViaticos;
        private System.Windows.Forms.Button btnReporte;
    }
}