namespace Reportes_de_Victor
{
    partial class FrmReporteAmortizacion
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsAmortizacion1 = new Reportes_de_Victor.Xsd.DsAmortizacion();
            ((System.ComponentModel.ISupportInitialize)(this.dsAmortizacion1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(137, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(560, 319);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dsAmortizacion1
            // 
            this.dsAmortizacion1.DataSetName = "DsAmortizacion";
            this.dsAmortizacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.dsAmortizacion1.Initialized += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FrmReporteAmortizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteAmortizacion";
            this.Text = "FrmReporteAmortizacion";
            ((System.ComponentModel.ISupportInitialize)(this.dsAmortizacion1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Xsd.DsAmortizacion dsAmortizacion1;
    }
}