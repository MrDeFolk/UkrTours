namespace Ukr_TourOp
{
    partial class Print_form
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_form));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ukrainets_tour_opDataSet1 = new Ukr_TourOp.Ukrainets_tour_opDataSet();
            this.printBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printTableAdapter = new Ukr_TourOp.Ukrainets_tour_opDataSetTableAdapters.PrintTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ukrainets_tour_opDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Print_DataSet";
            reportDataSource1.Value = this.printBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ukr_TourOp.tour_op.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ukrainets_tour_opDataSet1
            // 
            this.ukrainets_tour_opDataSet1.DataSetName = "Ukrainets_tour_opDataSet";
            this.ukrainets_tour_opDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printBindingSource
            // 
            this.printBindingSource.DataMember = "Print";
            this.printBindingSource.DataSource = this.ukrainets_tour_opDataSet1;
            // 
            // printTableAdapter
            // 
            this.printTableAdapter.ClearBeforeFill = true;
            // 
            // Print_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Print_form";
            this.Text = "Звіт на друк";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Print_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ukrainets_tour_opDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Ukrainets_tour_opDataSet ukrainets_tour_opDataSet1;
        private System.Windows.Forms.BindingSource printBindingSource;
        private Ukrainets_tour_opDataSetTableAdapters.PrintTableAdapter printTableAdapter;
    }
}